//CustomProgressBar.cs
//Programmé par : http://stackoverflow.com/users/300863/barry
// Description : Permet d'afficher du text sur une progressbar
//Modifié  par : Alexis Côté
//Le 30 novembre 2014 
//Modif :   Personnalisation de certaines methodes 
//        -Modification de la couleur du texte en fonction du pourcentage de la progressbar
//        -Le custom text doit maintenant comprendre le pourcentage( avant, il etait affiche par defaut meme quand le text etait null)


using System;
using System.Drawing;
using System.Windows.Forms;


namespace ProjetAeroport
{
    public class CustomProgressBar : ProgressBar
    {
        public enum ProgressBarDisplayText
        {
            Percentage,
            CustomText
        }

        //Property to set to decide whether to print a % or Text
        public ProgressBarDisplayText DisplayStyle { get; set; }

        //Property to hold the custom text
        public String CustomText { get; set; }

        public CustomProgressBar()
        {
            // Modify the ControlStyles flags
            //http://msdn.microsoft.com/en-us/library/system.windows.forms.controlstyles.aspx
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
           
           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            

            Rectangle rect = ClientRectangle;
            Graphics g = e.Graphics;

            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            rect.Inflate(-3, -3);
            if (Value > 0)
            {
                // As we doing this ourselves we need to draw the chunks on the progress bar
                Rectangle clip = new Rectangle(rect.X, rect.Y, (int)Math.Round(((float)Value / Maximum) * rect.Width), rect.Height);
                ProgressBarRenderer.DrawHorizontalChunks(g, clip);
            }

            // Set the Display text (Either a % amount or our custom text
            string text = DisplayStyle == ProgressBarDisplayText.Percentage ? Value.ToString() + '%' : CustomText;


            using (Font f = new Font("Segeo UI",11))
            {

                SizeF len = g.MeasureString(text, f);
                // Calculate the location of the text (the middle of progress bar)
                // Point location = new Point(Convert.ToInt32((rect.Width / 2) - (len.Width / 2)), Convert.ToInt32((rect.Height / 2) - (len.Height / 2)));
                Point location = new Point(Convert.ToInt32((Width / 2) - len.Width / 2), Convert.ToInt32((Height / 2) - len.Height / 2));
                // The commented-out code will centre the text into the highlighted area only. This will centre the text regardless of the highlighted area.
                // Draw the custom text


                //Couleur du text
                if (this.Value < 10)
                    g.DrawString(text, f, Brushes.Red, location);
                else if (this.Value < 25)
                    g.DrawString(text, f, Brushes.Orange, location);
                else
                    g.DrawString(text, f, Brushes.Black, location);
               
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams result = base.CreateParams;
                result.ExStyle |= 0x02000000; // WS_EX_COMPOSITED 
                return result;
            }
        }
    }
}

