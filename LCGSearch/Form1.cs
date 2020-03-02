using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace LCGSearch
{
    public partial class LCGSearchForm : Form
    {
        private readonly CultureInfo cultureInfo = new CultureInfo(@"fr-CA");

        public LCGSearchForm()
        {
            try
            {
                InitializeComponent();

                ToolTip searchToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                searchToolTip.SetToolTip(searchCLLI, @"Lancer la recherche");

                ToolTip npaToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                npaToolTip.SetToolTip(npaData, @"Code régional");

                ToolTip nxxToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                nxxToolTip.SetToolTip(nxxData, @"Plan de numérotage local");

                ToolTip xToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                xToolTip.SetToolTip(xData, @"Bloc");

                ToolTip rcToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                rcToolTip.SetToolTip(rcData, @"Centre tarifaire (Ville)");

                ToolTip regionToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                regionToolTip.SetToolTip(regionData, @"Province / État");

                ToolTip switchToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                switchToolTip.SetToolTip(switchData, @"Switch (CLLI)");

                ToolTip lataToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                lataToolTip.SetToolTip(lataData, @"Code d'acces local et zone de transport");

                ToolTip ocnToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                ocnToolTip.SetToolTip(ocnData, @"Code de compagnie");

                ToolTip exchToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                exchToolTip.SetToolTip(exchData, @"Code d'échange");

                ToolTip lirToolTip = new ToolTip
                {
                    ShowAlways = true
                };
                lirToolTip.SetToolTip(lirData, @"Région d'interconnexion locale");
            }
            catch (Exception)
            {
            }
        }

        private void UpdateResult(DataTable data)
        {
            if (resultView.InvokeRequired)
                resultView.Invoke(new Action(() => resultView.DataSource = data));
            else
                resultView.DataSource = data;
        }

        private async void SearchCLLI_Click(object sender, EventArgs e)
        {
            try
            {
                if (npaData.TextLength != 0 || regionData.TextLength != 0 || lataData.TextLength != 0 || lirData.TextLength != 0 || exchData.TextLength != 0)
                {
                    DataSet dataSet;
                    LocalCallingGuide lcg = new LocalCallingGuide();

                    dataSet = await lcg.Get(npaData.Text, nxxData.Text, xData.Text, rcData.Text, regionData.Text, switchData.Text, lataData.Text, ocnData.Text, exchData.Text, lirData.Text).ConfigureAwait(false);

                    if (dataSet.Tables.Count < 2)
                    {
                        MessageBox.Show(@"Aucun résultat.", @"Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataSet.Tables[1].Columns[@"npa"].ColumnName = @"NPA (Code régional)";
                        dataSet.Tables[1].Columns[@"nxx"].ColumnName = @"NXX (Plan de numérotage local)";
                        dataSet.Tables[1].Columns[@"X"].ColumnName = @"Block";
                        dataSet.Tables[1].Columns[@"exch"].ColumnName = @"Exchange";
                        dataSet.Tables[1].Columns[@"rc"].ColumnName = @"Rate Center";
                        dataSet.Tables[1].Columns[@"region"].ColumnName = @"Region Code";
                        dataSet.Tables[1].Columns[@"switch"].ColumnName = @"Switch CLLI";
                        dataSet.Tables[1].Columns[@"switchname"].ColumnName = @"Switch Name";
                        dataSet.Tables[1].Columns[@"switchtype"].ColumnName = @"Switch Type";
                        dataSet.Tables[1].Columns[@"ocn"].ColumnName = @"OCN Code";
                        dataSet.Tables[1].Columns[@"company-name"].ColumnName = @"Company Name";
                        dataSet.Tables[1].Columns[@"company-type"].ColumnName = @"Company Type";
                        dataSet.Tables[1].Columns[@"ilec-ocn"].ColumnName = @"ILEC OCN";
                        dataSet.Tables[1].Columns[@"ilec-name"].ColumnName = @"ILEC Name";
                        dataSet.Tables[1].Columns[@"lata"].ColumnName = @"LATA Code";
                        dataSet.Tables[1].Columns[@"lir"].ColumnName = @"Local Exchange Rate";
                        dataSet.Tables[1].Columns[@"rc-v"].ColumnName = @"RC Vertical";
                        dataSet.Tables[1].Columns[@"rc-h"].ColumnName = @"RC Horizontal";
                        dataSet.Tables[1].Columns[@"rc-lat"].ColumnName = @"RC Latitude";
                        dataSet.Tables[1].Columns[@"rc-lon"].ColumnName = @"RC Longitude";
                        dataSet.Tables[1].Columns[@"effdate"].ColumnName = @"Effective Date";
                        dataSet.Tables[1].Columns[@"discdate"].ColumnName = @"Discard Date";
                        dataSet.Tables[1].Columns[@"udate"].ColumnName = @"Update Date";
                        UpdateResult(dataSet.Tables[1]);
                    }
                }
                else
                {
                    MessageBox.Show(@"Au moins un des champs suivants doit etre remplis: NPA, Region, LATA, LIR ou Exchange.", @"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void NpaData_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(npaData.Text))
                {
                    UInt64 i = UInt64.Parse(npaData.Text, NumberStyles.Integer, cultureInfo);
                    if (i < 201)
                    {
                        MessageBox.Show(@"Veuillez sélectionner une valeur égal ou suppérieur à 201.", @"NPA non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        npaData.Text = String.Empty;
                        npaData.Select();
                    }
                    else if (i > 999)
                    {
                        MessageBox.Show(@"Veuillez sélectionner une valeur égal ou inférieur à 999.", @"NPA non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        npaData.Text = String.Empty;
                        npaData.Select();
                    }
                    else
                    {
                        npaData.Text = i.ToString(cultureInfo);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void NxxData_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(nxxData.Text))
                {
                    UInt64 i = UInt64.Parse(nxxData.Text, NumberStyles.Integer, cultureInfo);
                    if (i < 200)
                    {
                        MessageBox.Show(@"Veuillez sélectionner une valeur égal ou suppérieur à 200.", @"NXX non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nxxData.Text = String.Empty;
                        nxxData.Select();
                    }
                    else if (i > 999)
                    {
                        MessageBox.Show(@"Veuillez sélectionner une valeur égal ou inférieur à 999.", @"NXX non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nxxData.Text = String.Empty;
                        nxxData.Select();
                    }
                    else
                    {
                        nxxData.Text = i.ToString(cultureInfo);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void NpaData_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void XData_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                xData.Text = xData.Text.ToUpper(cultureInfo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void XData_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar.ToString(cultureInfo).ToUpper(cultureInfo) == @"A"))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void OcnData_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void RegionData_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void RegionData_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(regionData.Text))
                {
                    regionData.Text = regionData.Text.ToUpper(cultureInfo);
                    if (regionData.Text.Length != 2)
                    {
                        MessageBox.Show(@"2 lettres par région.", @"Région", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        regionData.Select();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LataData_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LataData_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(lataData.Text))
                {
                    UInt64 i = UInt64.Parse(lataData.Text, NumberStyles.Integer, cultureInfo);
                    if (i < 100)
                    {
                        MessageBox.Show(@"Veuillez sélectionner une valeur égal ou suppérieur à 100.", @"LATA non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lataData.Text = String.Empty;
                        lataData.Select();
                    }
                    else if (i > 99999)
                    {
                        MessageBox.Show(@"Veuillez sélectionner une valeur égal ou inférieur à 99999.", @"LATA non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lataData.Text = String.Empty;
                        lataData.Select();
                    }
                    else
                    {
                        lataData.Text = i.ToString(cultureInfo);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SwitchData_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(switchData.Text))
                {
                    if (switchData.Text.Length != 11)
                    {
                        MessageBox.Show(@"Code Switch doit etre exactement 11 caracteres.", @"Switch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        switchData.Select();
                    }
                    else
                    {
                        switchData.Text = switchData.Text.ToUpper(cultureInfo);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ExchData_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ExchData_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(exchData.Text))
                {
                    if (exchData.Text.Length != 6)
                    {
                        MessageBox.Show(@"Exchange doit etre exactement 6 caracteres.", @"Exchange", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        exchData.Select();
                    }
                    else
                    {
                        exchData.Text = exchData.Text.ToUpper(cultureInfo);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LirData_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LirData_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(lirData.Text))
                {
                    if (lirData.Text.Length != 6)
                    {
                        MessageBox.Show(@"Exchange doit etre exactement 6 caracteres.", @"Exchange", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lirData.Select();
                    }
                    else
                    {
                        lirData.Text = lirData.Text.ToUpper(cultureInfo);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AboutCLick(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
            
        }
    }
}