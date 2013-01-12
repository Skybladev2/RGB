using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RGB
{
    public partial class Form1 : Form
    {
        private float rCoeff = 0.299f;
        private float gCoeff = 0.587f;
        private float bCoeff = 0.114f;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rdbFindGray.Checked)
            {
                FindGray();
            }

            if (rdbFindR.Checked)
            {
                FindRed();
            }

            if (rdbFindG.Checked)
            {
                FindGreen();
            }

            if (rdbFindB.Checked)
            {
                FindBlue();
            }
        }

        private void FindBlue()
        {
            float gray = (float)numGray.Value;
            float r = (float)numR.Value;
            float g = (float)numG.Value;

            float b = (gray - rCoeff * r - gCoeff * g) / bCoeff;

            ApplyColors(r, g, b, gray);

            numB.Value = (decimal)b;
        }

        private void FindGreen()
        {
            float gray = (float)numGray.Value;
            float r = (float)numR.Value;
            float b = (float)numB.Value;

            float g = (gray - rCoeff * r - bCoeff * b) / gCoeff;

            ApplyColors(r, g, b, gray);

            numG.Value = (decimal)g;
        }

        private void FindRed()
        {
            float gray = (float)numGray.Value;
            float g = (float)numG.Value;
            float b = (float)numB.Value;

            float r = (gray - gCoeff * g - bCoeff * b) / rCoeff;

            ApplyColors(r, g, b, gray);

            numR.Value = (decimal)r;
        }

        private void ApplyColors(float r, float g, float b, float gray)
        {
            ApplyColor(r, numR);
            ApplyColor(g, numG);
            ApplyColor(b, numB);
            ApplyColor(gray, numGray);
        }

        private void ApplyColor(float value, NumericUpDown control)
        {
            Color errorColor = Color.Red;
            Color normalColor = Color.Black;

            if (value < 0 || value > 255)
            {
                control.ForeColor = errorColor;
            }
            else
            {
                control.ForeColor = normalColor;
            }
        }

        private void FindGray()
        {
            float r = (float)numR.Value;
            float g = (float)numG.Value;
            float b = (float)numB.Value;
            float gray = rCoeff * r + gCoeff * g + bCoeff * b;

            ApplyColors(r, g, b, gray);

            numGray.Value = (decimal)gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
