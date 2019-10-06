using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2
{
    public partial class Main_form : Form
    {
        bool clear_stts = false, oprd_change = false, count_fnshd = false, error = false, dot_mode = false, mr_do = false;
        byte oprt = 0, up_out_slct = 1, dot_dgts_slct = 2;
        double a = 0, b = 0, m = 0, dot_dgts = 0.1;

        public Main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            Screen.Text = a.ToString();
        }

        void Rst()
        {
            if (count_fnshd)
            {
                count_fnshd = false;
                if (!oprd_change) a = 0;
                else b = 0;
            }
            if (mr_do)
            {
                mr_do = false;
                if (!oprd_change) a = 0;
                else b = 0;
            }
        }

        void Oprti_rst()
        {
            oprt = 0; oprd_change = false;
        }

        void Dot_rst()
        {
            dot_dgts = 0.1; dot_mode = false;
        }

        void Label_text_fmt()
        {
            if (up_out_slct == 0)
            {
                a *= Math.Pow(10, dot_dgts_slct);
                a = Math.Ceiling(a);
                a /= Math.Pow(10, dot_dgts_slct);
                Screen.Text = a.ToString();
            }
            else if (up_out_slct == 2)
            {
                a *= Math.Pow(10, dot_dgts_slct);
                a = Math.Floor(a);
                a /= Math.Pow(10, dot_dgts_slct);
                Screen.Text = a.ToString();
            }
            else Screen.Text = Math.Round(a, dot_dgts_slct, MidpointRounding.AwayFromZero).ToString();
        }

        void Count()
        {
            if (oprt == 4 && b == 0)
            {
                error = true; clear_stts = false;
                Screen.Text = "E";
            }
            else
            {
                switch (oprt)
                {
                    case 1:
                        a += b; b = 0;
                        Label_text_fmt();
                        break;
                    case 2:
                        a -= b; b = 0;
                        Label_text_fmt();
                        break;
                    case 3:
                        a *= b; b = 0;
                        Label_text_fmt();
                        break;
                    case 4:
                        a /= b; b = 0;
                        Label_text_fmt();
                        break;
                    case 5:
                        a = Math.Pow(a, b); b = 0;
                        Label_text_fmt();
                        break;
                }
            }
        }

        private void TrackBar_value_change(object sender, EventArgs e)
        {
            TrackBar trckb_value_copy = (TrackBar)sender;
            byte trckb_value = byte.Parse(trckb_value_copy.Tag.ToString());
            switch (trckb_value)
            {
                case 1:
                    up_out_slct = (byte)TrackBar_uos.Value;
                    break;
                case 2:
                    dot_dgts_slct = (byte)TrackBar_dds.Value;
                    break;
            }
        }

        private void Button_number_clck(object sender, EventArgs e)
        {
            if (!error)
            {
                clear_stts = true;
                Rst();
                Button button_value_copy = (Button)sender;
                byte button_value = byte.Parse(button_value_copy.Tag.ToString());
                if (!dot_mode)
                {
                    if (!oprd_change)
                    {
                        a *= 10; a += button_value;
                        Screen.Text = a.ToString();
                    }
                    else
                    {
                        b *= 10; b += button_value;
                        Screen.Text = b.ToString();
                    }
                }
                else
                {
                    if (!oprd_change)
                    {
                        a += (button_value * dot_dgts);
                        Screen.Text = a.ToString();
                    }
                    else
                    {
                        b += (button_value * dot_dgts);
                        Screen.Text = b.ToString();
                    }
                    dot_dgts *= 0.1;
                }
            }
        }

        private void Button_oprt_clck(object sender, EventArgs e)
        {
            if (!error)
            {
                oprd_change = true; clear_stts = false;
                Dot_rst();
                Count();
                Button button_value_copy = (Button)sender;
                byte button_value = byte.Parse(button_value_copy.Tag.ToString());
                oprt = button_value;
            }
        }

        private void Button_function_clck(object sender, EventArgs e)
        {
            if (!error)
            {
                Button button_value_copy = (Button)sender;
                byte button_value = byte.Parse(button_value_copy.Tag.ToString());
                switch (button_value)
                {
                    case 1:
                        mr_do = true; clear_stts = true;
                        Dot_rst();
                        if (!oprd_change)
                        {
                            a = m;
                            Screen.Text = a.ToString();
                        }
                        else
                        {
                            b = m;
                            Screen.Text = b.ToString();
                        }
                        break;
                    case 2:
                        if (!oprd_change) m = a;
                        else m = b;
                        break;
                    case 3:
                        if (!oprd_change) m += a;
                        else m += b;
                        break;
                    case 4:
                        if (!oprd_change) m -= a;
                        else m -= b;
                        break;
                    case 5:
                        Rst();
                        if (!oprd_change)
                        {
                            a *= -1;
                            Screen.Text = a.ToString();
                        }
                        else
                        {
                            b *= -1;
                            Screen.Text = b.ToString();
                        }
                        break;
                    case 6:
                        dot_mode = true; clear_stts = true;
                        Rst();
                        if (!oprd_change) Screen.Text = a.ToString();
                        else Screen.Text = b.ToString();
                        break;
                    case 7:
                        count_fnshd = true; clear_stts = false;
                        Dot_rst();
                        Count();
                        Oprti_rst();
                        break;
                }
            }
        }

        private void Button_clear_clck(object sender, EventArgs e)
        {
            Button button_value_copy = (Button)sender;
            byte button_value = byte.Parse(button_value_copy.Tag.ToString());
            switch (button_value)
            {
                case 1:
                    if (!clear_stts)
                    {
                        error = false;
                        Oprti_rst();
                        a = 0;
                        Screen.Text = a.ToString();
                    }
                    else
                    {
                        clear_stts = false;
                        Dot_rst();
                        if (!oprd_change)
                        {
                            a = 0;
                            Screen.Text = a.ToString();
                        }
                        else
                        {
                            b = 0;
                            Screen.Text = b.ToString();
                        }
                    }
                    break;
                case 2:
                    m = 0;
                    break;
            }
        }
    }
}
