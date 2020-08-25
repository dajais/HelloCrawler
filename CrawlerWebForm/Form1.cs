using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
			pos1Char.Location = new Point(600, 700);
			equipHead.Hide();
			equipChest.Hide();
			equipPants.Hide();
			equipBoots.Hide();
			equipShoulder.Hide();
			equipGloves.Hide();
			equipWeapon.Hide();

			hpBar.Maximum = 100;
			hpBar.Value = Player.Hp;

			textBox.Hide();

		}

		private void posCharClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{ 
				pos1Char.BackColor = Color.SkyBlue;
			}
			if (e.Button == MouseButtons.Right)
			{
				textBox.Show();
				pos1Char.Location = textBox.Location;
				
				

			}

		}

		private void posClick1(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos2.Location || pos1Char.Location == pos4.Location)
				{
					pos1Char.Location = new Point(500, 600);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos4.BackgroundImage = background;
					pos2.BackgroundImage = background;
				}
			}
		}

		private void posClick2(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos1.Location || pos1Char.Location == pos3.Location || pos1Char.Location == pos5.Location || pos1Char.Location == pos10.Location)
				{
					pos1Char.Location = new Point(550, 600);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos1.BackgroundImage = background;
					pos3.BackgroundImage = background;
					pos5.BackgroundImage = background;
					pos10.BackgroundImage = background;
				}
			}
		}

		private void posClick3(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos2.Location || pos1Char.Location == pos6.Location)
				{
					pos1Char.Location = new Point(600, 600);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos2.BackgroundImage = background;
					pos6.BackgroundImage = background;
				}
			}
		}

		private void posClick4(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos1.Location || pos1Char.Location == pos5.Location || pos1Char.Location == pos7.Location)
				{
					pos1Char.Location = new Point(500, 650);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos1.BackgroundImage = background;
					pos5.BackgroundImage = background;
					pos7.BackgroundImage = background;
				}
			}
		}

		private void posClick5(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos2.Location || pos1Char.Location == pos4.Location || pos1Char.Location == pos6.Location || pos1Char.Location == pos8.Location)
				{
					pos1Char.Location = new Point(550, 650);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos2.BackgroundImage = background;
					pos4.BackgroundImage = background;
					pos6.BackgroundImage = background;
					pos8.BackgroundImage = background;
				}
			}
		}

		private void posClick6(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos3.Location || pos1Char.Location == pos5.Location || pos1Char.Location == pos9.Location)
				{
					pos1Char.Location = new Point(600, 650);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos3.BackgroundImage = background;
					pos5.BackgroundImage = background;
					pos9.BackgroundImage = background;


				}
			}
		}

		private void posClick7(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos4.Location || pos1Char.Location == pos8.Location)
				{
					pos1Char.Location = new Point(500, 700);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos4.BackgroundImage = background;
					pos8.BackgroundImage = background;


				}
			}
		}

		private void posClick8(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos5.Location || pos1Char.Location == pos7.Location || pos1Char.Location == pos9.Location)
				{
					pos1Char.Location = new Point(550, 700);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos5.BackgroundImage = background;
					pos7.BackgroundImage = background;
					pos9.BackgroundImage = background;

					Player.Hp = 80;
					hpBar.Value = Player.Hp;
				}
			}
		}

		private void posClick9(object sender, MouseEventArgs e)
		{
			if ((string)listMovement.SelectedItem == "Walk")
			{
				if (e.Button == MouseButtons.Left)
				{
					if (pos1Char.Location == pos6.Location || pos1Char.Location == pos8.Location)
					{
						pos1Char.Location = new Point(600, 700);
						pos1Char.BackColor = Color.White;

						Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
						pos6.BackgroundImage = background;
						pos8.BackgroundImage = background;

					}
				}
			}
		}


		private void posClick10(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos2.Location || pos1Char.Location == pos11.Location)
				{
					pos1Char.Location = new Point(550, 550);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos2.BackgroundImage = background;
					pos11.BackgroundImage = background;

				}
			}
		}

		private void posClick11(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos10.Location || pos1Char.Location == pos12.Location || pos1Char.Location == pos17.Location)
				{
					pos1Char.Location = new Point(550, 500);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos10.BackgroundImage = background;
					pos12.BackgroundImage = background;
					pos17.BackgroundImage = background;
				}
			}
		}

		private void posClick12(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos11.Location || pos1Char.Location == pos13.Location || pos1Char.Location == pos14.Location)
				{
					pos1Char.Location = new Point(600, 500);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos11.BackgroundImage = background;
					pos13.BackgroundImage = background;
					pos14.BackgroundImage = background;

				}
			}
		}

		private void posClick13(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos12.Location)
				{
					pos1Char.Location = new Point(600, 450);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos12.BackgroundImage = background;


				}
			}
		}

		private void posClick14(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos12.Location || pos1Char.Location == pos15.Location)
				{
					pos1Char.Location = new Point(650, 500);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos12.BackgroundImage = background;
					pos15.BackgroundImage = background;
				}
			}
		}

		private void posClick15(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos14.Location || pos1Char.Location == pos16.Location)
				{
					pos1Char.Location = new Point(700, 500);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos14.BackgroundImage = background;
					pos16.BackgroundImage = background;
				}
			}
		}

		private void posClick16(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos15.Location)
				{
					pos1Char.Location = new Point(700, 550);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos15.BackgroundImage = background;
				}
			}
		}

		private void posClick17(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos11.Location || pos1Char.Location == pos18.Location || pos1Char.Location == pos19.Location)
				{
					pos1Char.Location = new Point(500, 500);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos11.BackgroundImage = background;
					pos18.BackgroundImage = background;
					pos19.BackgroundImage = background;
				}
			}
		}

		private void posClick18(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos17.Location)
				{
					pos1Char.Location = new Point(450, 500);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos17.BackgroundImage = background;



				}
			}
		}

		private void posClick19(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos17.Location || pos1Char.Location == pos20.Location)
				{
					pos1Char.Location = new Point(500, 450);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos17.BackgroundImage = background;
					pos20.BackgroundImage = background;

				}
			}
		}

		private void posClick20(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos19.Location || pos1Char.Location == pos21.Location)
				{
					pos1Char.Location = new Point(500, 400);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos19.BackgroundImage = background;
					pos21.BackgroundImage = background;
				}
			}
		}

		private void posClick21(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos20.Location || pos1Char.Location == pos22.Location)
				{
					pos1Char.Location = new Point(500, 350);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos20.BackgroundImage = background;
					pos22.BackgroundImage = background;
				}
			}
		}

		private void posClick22(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (pos1Char.Location == pos21.Location)
				{
					pos1Char.Location = new Point(550, 350);
					pos1Char.BackColor = Color.White;

					Image background = new Bitmap(@"C:\Users\licja\Dropbox\Hello Crawler\CrawlerWebForm\Rock.png");
					pos21.BackgroundImage = background;

				}
			}
		}

		private void equipClick(object sender, MouseEventArgs e)
		{
			if (equipBoots.Visible == true)
			{
				equipHead.Hide();
				equipChest.Hide();
				equipPants.Hide();
				equipBoots.Hide();
				equipShoulder.Hide();
				equipGloves.Hide();
				equipWeapon.Hide();
			}
			else
			{
				equipHead.Show();
				equipChest.Show();
				equipPants.Show();
				equipBoots.Show();
				equipShoulder.Show();
				equipGloves.Show();
				equipWeapon.Show();
			}
		}

		private void hoverEquip(object sender, EventArgs e)
		{
			ToolTip toolTip1 = new ToolTip();

			toolTip1.AutoPopDelay = 1000;
			toolTip1.ShowAlways = true;
			toolTip1.SetToolTip(buttonEquip, "Open Equip");
		}

	
	}
}
