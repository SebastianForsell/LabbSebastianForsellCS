using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(weightInput.Text);
            Converter();
        }
        private void Converter()
        {
            switch (fromList.SelectedValue)
            {
                case "gram":
                    double gram = double.Parse(weightInput.Text);
                    backConverter(gram);
                    break;
                case "hekto":
                    double hekto = double.Parse(weightInput.Text);
                    hekto *= 100;
                    backConverter(hekto);
                    break;
                case "kilo":
                    double kilo = double.Parse(weightInput.Text);
                    kilo *= 1000;
                    backConverter(kilo);
                    break;
                case "milli":
                    double milli = double.Parse(weightInput.Text);
                    milli /= 1000;
                    backConverter(milli);
                    break;
                default:
                    break;
            }
        }
        private void backConverter(double weightValue)
        {
            switch (toList.SelectedValue)
            {
                case "gram":
                    convertResult.Text = ToString(weightValue);
                    break;
                case "hekto":
                    weightValue /= 100;
                    convertResult.Text = ToString(weightValue);
                    break;
                case "kilo":
                    weightValue /= 1000;
                    convertResult.Text = ToString(weightValue);
                    break;
                case "milli":
                    weightValue *= 1000;
                    convertResult.Text = ToString(weightValue);
                    break;
                default:
                    break;
            }
        }
        private string ToString(double weightValue)
        {
            switch (toList.SelectedValue)
            {
                case "gram":
                    return $"Resultat: {weightValue}g.";
                case "hekto":
                    return $"Resultat: {weightValue}hg";
                case "kilo":
                    return $"Resultat: {weightValue}kg";
                case "milli":
                    return $"Resultat: {weightValue}mg";
                default:
                    throw new Exception("hoppsan, där gick något fel ... (ToString switch)");
            }
            
        }
    }
}