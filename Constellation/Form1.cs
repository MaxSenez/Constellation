//Max Senez Constellation Project Septemer 9 2017
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Constellation
{
    public partial class constForm : Form
    {
        int flag = 0;
        public constForm()
        {
            InitializeComponent();
        }

        private void constForm_Load(object sender, EventArgs e)
        {

        }

        private void constForm_Click(object sender, EventArgs e)
        {
            //Setup
            Graphics formGraphics = this.CreateGraphics();

            //Clear Logo
            formGraphics.Clear(Color.Black);

            SoundPlayer spaceMusic = new SoundPlayer(Properties.Resources.Space_Music);
            SoundPlayer textNoise = new SoundPlayer(Properties.Resources.chimes);
            SoundPlayer starSound = new SoundPlayer(Properties.Resources.Ding);
            SoundPlayer completeSound = new SoundPlayer(Properties.Resources.Windows_Print_complete);

            Font starFont = new Font("Racer", 10, FontStyle.Bold);
            Font infoFont = new Font("Tandysoft", 6, FontStyle.Bold);

            Pen starPen = new Pen(Color.White, 2);
            Pen highlightPen = new Pen(Color.Yellow, 2);
            Pen firePen = new Pen(Color.Red, 2);

            SolidBrush fireBrush = new SolidBrush(Color.Red);
            SolidBrush fontBrush = new SolidBrush(Color.White);
            SolidBrush infoBrush = new SolidBrush(Color.Red);
            SolidBrush starBrush = new SolidBrush(Color.White);

            if(flag == 1)
            {
                //Stop Music
                spaceMusic.Stop();

                //Title
                formGraphics.DrawString("Scorpius", starFont, fontBrush, 20, 80);

                //Star Points

                //Branches
                formGraphics.DrawArc(starPen, 378, 133, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 392, 137, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 400, 162, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 400, 191, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 400, 218, 3, 3, 30, 360);

                //Base
                formGraphics.DrawArc(starPen, 358, 183, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 341, 188, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 329, 203, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 303, 252, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 298, 283, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 266, 336, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 226, 313, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 218, 292, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 230, 275, 3, 3, 30, 360);
                formGraphics.DrawArc(starPen, 236, 277, 3, 3, 30, 360);

                //Small Background stars (warning lots)
                formGraphics.DrawArc(starPen, 57, 27, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 36, 39, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 26, 40, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 14, 32, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 112, 5, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 70, 57, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 89, 53, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 121, 59, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 155, 46, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 164, 59, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 207, 43, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 226, 16, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 281, 6, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 372, 7, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 331, 59, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 384, 54, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 472, 56, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 203, 81, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 242, 79, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 265, 102, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 346, 90, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 304, 60, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 419, 112, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 462, 98, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 59, 121, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 210, 102, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 349, 124, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 441, 104, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 5, 150, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 38, 171, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 124, 151, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 147, 154, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 205, 153, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 246, 146, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 336, 149, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 474, 152, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 154, 120, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 10, 214, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 76, 209, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 126, 194, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 166, 178, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 235, 170, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 257, 190, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 442, 215, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 67, 243, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 143, 228, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 170, 227, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 240, 216, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 357, 223, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 472, 245, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 334, 258, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 411, 255, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 199, 261, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 145, 265, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 68, 279, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 19, 292, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 50, 312, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 122, 323, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 178, 308, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 212, 327, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 266, 297, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 351, 297, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 409, 328, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 437, 307, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 485, 289, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 329, 338, 2, 2, 30, 360);
                formGraphics.DrawArc(starPen, 480, 329, 2, 2, 30, 360);
                Thread.Sleep(2000);

                //Bring out stars
                formGraphics.DrawArc(highlightPen, 236, 277, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 238, 279, 232, 277);

                formGraphics.DrawArc(highlightPen, 230, 275, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 232, 277, 220, 294);

                formGraphics.DrawArc(highlightPen, 218, 292, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 220, 294, 228, 315);

                formGraphics.DrawArc(highlightPen, 226, 313, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 228, 315, 268, 338);

                formGraphics.DrawArc(highlightPen, 266, 336, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 268, 338, 300, 285);

                formGraphics.DrawArc(highlightPen, 298, 283, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 300, 285, 305, 254);

                formGraphics.DrawArc(highlightPen, 303, 252, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 305, 254, 331, 205);

                formGraphics.DrawArc(highlightPen, 329, 203, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 331, 205, 343, 190);

                formGraphics.DrawArc(highlightPen, 341, 188, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 343, 190, 360, 185);

                formGraphics.DrawArc(highlightPen, 358, 183, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 360, 185, 380, 135);

                formGraphics.DrawArc(highlightPen, 378, 133, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 360, 185, 394, 139);

                formGraphics.DrawArc(highlightPen, 392, 137, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 360, 185, 402, 164);

                formGraphics.DrawArc(highlightPen, 400, 162, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 360, 185, 402, 193);

                formGraphics.DrawArc(highlightPen, 400, 191, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);
                formGraphics.DrawLine(starPen, 360, 185, 402, 220);

                formGraphics.DrawArc(highlightPen, 400, 218, 5, 5, 30, 360);
                starSound.Play();
                Thread.Sleep(500);

                //Blink 3
                formGraphics.DrawArc(starPen, 236, 277, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 238, 279, 232, 277);
                formGraphics.DrawArc(starPen, 230, 275, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 232, 277, 220, 294);
                formGraphics.DrawArc(starPen, 218, 292, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 220, 294, 228, 315);
                formGraphics.DrawArc(starPen, 226, 313, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 228, 315, 268, 338);
                formGraphics.DrawArc(starPen, 266, 336, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 268, 338, 300, 285);
                formGraphics.DrawArc(starPen, 298, 283, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 300, 285, 305, 254);
                formGraphics.DrawArc(starPen, 303, 252, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 305, 254, 331, 205);
                formGraphics.DrawArc(starPen, 329, 203, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 331, 205, 343, 190);
                formGraphics.DrawArc(starPen, 341, 188, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 343, 190, 360, 185);
                formGraphics.DrawArc(starPen, 358, 183, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 380, 135);
                formGraphics.DrawArc(starPen, 378, 133, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 394, 139);
                formGraphics.DrawArc(starPen, 392, 137, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 164);
                formGraphics.DrawArc(starPen, 400, 162, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 193);
                formGraphics.DrawArc(starPen, 400, 191, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 220);
                formGraphics.DrawArc(starPen, 400, 218, 5, 5, 30, 360);
                Thread.Sleep(500);

                formGraphics.DrawArc(highlightPen, 236, 277, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 238, 279, 232, 277);
                formGraphics.DrawArc(highlightPen, 230, 275, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 232, 277, 220, 294);
                formGraphics.DrawArc(highlightPen, 218, 292, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 220, 294, 228, 315);
                formGraphics.DrawArc(highlightPen, 226, 313, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 228, 315, 268, 338);
                formGraphics.DrawArc(highlightPen, 266, 336, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 268, 338, 300, 285);
                formGraphics.DrawArc(highlightPen, 298, 283, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 300, 285, 305, 254);
                formGraphics.DrawArc(highlightPen, 303, 252, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 305, 254, 331, 205);
                formGraphics.DrawArc(highlightPen, 329, 203, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 331, 205, 343, 190);
                formGraphics.DrawArc(highlightPen, 341, 188, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 343, 190, 360, 185);
                formGraphics.DrawArc(highlightPen, 358, 183, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 380, 135);
                formGraphics.DrawArc(highlightPen, 378, 133, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 394, 139);
                formGraphics.DrawArc(highlightPen, 392, 137, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 402, 164);
                formGraphics.DrawArc(highlightPen, 400, 162, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 402, 193);
                formGraphics.DrawArc(highlightPen, 400, 191, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 402, 220);
                formGraphics.DrawArc(highlightPen, 400, 218, 5, 5, 30, 360);
                completeSound.Play();
                Thread.Sleep(500);

                formGraphics.DrawArc(starPen, 236, 277, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 238, 279, 232, 277);
                formGraphics.DrawArc(starPen, 230, 275, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 232, 277, 220, 294);
                formGraphics.DrawArc(starPen, 218, 292, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 220, 294, 228, 315);
                formGraphics.DrawArc(starPen, 226, 313, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 228, 315, 268, 338);
                formGraphics.DrawArc(starPen, 266, 336, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 268, 338, 300, 285);
                formGraphics.DrawArc(starPen, 298, 283, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 300, 285, 305, 254);
                formGraphics.DrawArc(starPen, 303, 252, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 305, 254, 331, 205);
                formGraphics.DrawArc(starPen, 329, 203, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 331, 205, 343, 190);
                formGraphics.DrawArc(starPen, 341, 188, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 343, 190, 360, 185);
                formGraphics.DrawArc(starPen, 358, 183, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 380, 135);
                formGraphics.DrawArc(starPen, 378, 133, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 394, 139);
                formGraphics.DrawArc(starPen, 392, 137, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 164);
                formGraphics.DrawArc(starPen, 400, 162, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 193);
                formGraphics.DrawArc(starPen, 400, 191, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 220);
                formGraphics.DrawArc(starPen, 400, 218, 5, 5, 30, 360);
                Thread.Sleep(500);

                formGraphics.DrawArc(highlightPen, 236, 277, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 238, 279, 232, 277);
                formGraphics.DrawArc(highlightPen, 230, 275, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 232, 277, 220, 294);
                formGraphics.DrawArc(highlightPen, 218, 292, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 220, 294, 228, 315);
                formGraphics.DrawArc(highlightPen, 226, 313, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 228, 315, 268, 338);
                formGraphics.DrawArc(highlightPen, 266, 336, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 268, 338, 300, 285);
                formGraphics.DrawArc(highlightPen, 298, 283, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 300, 285, 305, 254);
                formGraphics.DrawArc(highlightPen, 303, 252, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 305, 254, 331, 205);
                formGraphics.DrawArc(highlightPen, 329, 203, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 331, 205, 343, 190);
                formGraphics.DrawArc(highlightPen, 341, 188, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 343, 190, 360, 185);
                formGraphics.DrawArc(highlightPen, 358, 183, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 380, 135);
                formGraphics.DrawArc(highlightPen, 378, 133, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 394, 139);
                formGraphics.DrawArc(highlightPen, 392, 137, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 402, 164);
                formGraphics.DrawArc(highlightPen, 400, 162, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 402, 193);
                formGraphics.DrawArc(highlightPen, 400, 191, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 402, 220);
                formGraphics.DrawArc(highlightPen, 400, 218, 5, 5, 30, 360);
                completeSound.Play();
                Thread.Sleep(500);


                formGraphics.DrawArc(starPen, 236, 277, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 238, 279, 232, 277);
                formGraphics.DrawArc(starPen, 230, 275, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 232, 277, 220, 294);
                formGraphics.DrawArc(starPen, 218, 292, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 220, 294, 228, 315);
                formGraphics.DrawArc(starPen, 226, 313, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 228, 315, 268, 338);
                formGraphics.DrawArc(starPen, 266, 336, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 268, 338, 300, 285);
                formGraphics.DrawArc(starPen, 298, 283, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 300, 285, 305, 254);
                formGraphics.DrawArc(starPen, 303, 252, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 305, 254, 331, 205);
                formGraphics.DrawArc(starPen, 329, 203, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 331, 205, 343, 190);
                formGraphics.DrawArc(starPen, 341, 188, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 343, 190, 360, 185);
                formGraphics.DrawArc(starPen, 358, 183, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 380, 135);
                formGraphics.DrawArc(starPen, 378, 133, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 394, 139);
                formGraphics.DrawArc(starPen, 392, 137, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 164);
                formGraphics.DrawArc(starPen, 400, 162, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 193);
                formGraphics.DrawArc(starPen, 400, 191, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 220);
                formGraphics.DrawArc(starPen, 400, 218, 5, 5, 30, 360);
                Thread.Sleep(500);

                formGraphics.DrawArc(highlightPen, 236, 277, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 238, 279, 232, 277);
                formGraphics.DrawArc(highlightPen, 230, 275, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 232, 277, 220, 294);
                formGraphics.DrawArc(highlightPen, 218, 292, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 220, 294, 228, 315);
                formGraphics.DrawArc(highlightPen, 226, 313, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 228, 315, 268, 338);
                formGraphics.DrawArc(highlightPen, 266, 336, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 268, 338, 300, 285);
                formGraphics.DrawArc(highlightPen, 298, 283, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 300, 285, 305, 254);
                formGraphics.DrawArc(highlightPen, 303, 252, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 305, 254, 331, 205);
                formGraphics.DrawArc(highlightPen, 329, 203, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 331, 205, 343, 190);
                formGraphics.DrawArc(highlightPen, 341, 188, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 343, 190, 360, 185);
                formGraphics.DrawArc(highlightPen, 358, 183, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 380, 135);
                formGraphics.DrawArc(highlightPen, 378, 133, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 394, 139);
                formGraphics.DrawArc(highlightPen, 392, 137, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 402, 164);
                formGraphics.DrawArc(highlightPen, 400, 162, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 402, 193);
                formGraphics.DrawArc(highlightPen, 400, 191, 5, 5, 30, 360);
                formGraphics.DrawLine(highlightPen, 360, 185, 402, 220);
                formGraphics.DrawArc(highlightPen, 400, 218, 5, 5, 30, 360);
                completeSound.Play();
                Thread.Sleep(500);

                formGraphics.DrawArc(highlightPen, 236, 277, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 238, 279, 232, 277);
                formGraphics.DrawArc(highlightPen, 230, 275, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 232, 277, 220, 294);
                formGraphics.DrawArc(highlightPen, 218, 292, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 220, 294, 228, 315);
                formGraphics.DrawArc(highlightPen, 226, 313, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 228, 315, 268, 338);
                formGraphics.DrawArc(highlightPen, 266, 336, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 268, 338, 300, 285);
                formGraphics.DrawArc(highlightPen, 298, 283, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 300, 285, 305, 254);
                formGraphics.DrawArc(highlightPen, 303, 252, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 305, 254, 331, 205);
                formGraphics.DrawArc(highlightPen, 329, 203, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 331, 205, 343, 190);
                formGraphics.DrawArc(highlightPen, 341, 188, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 343, 190, 360, 185);
                formGraphics.DrawArc(highlightPen, 358, 183, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 380, 135);
                formGraphics.DrawArc(highlightPen, 378, 133, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 394, 139);
                formGraphics.DrawArc(highlightPen, 392, 137, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 164);
                formGraphics.DrawArc(highlightPen, 400, 162, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 193);
                formGraphics.DrawArc(highlightPen, 400, 191, 5, 5, 30, 360);
                formGraphics.DrawLine(starPen, 360, 185, 402, 220);
                formGraphics.DrawArc(highlightPen, 400, 218, 5, 5, 30, 360);
                Thread.Sleep(500);

                //Info text
                textNoise.Play();
                formGraphics.DrawString("Scorpius is a large zodiacal constellation", infoFont, infoBrush, 20, 120);
                formGraphics.DrawString("lying between Libra and Sagittarius and", infoFont, infoBrush, 20, 130);
                formGraphics.DrawString("crossed by the Milky Way. A constellation", infoFont, infoBrush, 20, 140);
                formGraphics.DrawString("in the Southern Hemisphere near Libra and", infoFont, infoBrush, 20, 150);
                formGraphics.DrawString("Sagittarius. Scorpius contains the bright", infoFont, infoBrush, 20, 160);
                formGraphics.DrawString("star Antares and is the eighth sign of", infoFont, infoBrush, 20, 170);
                formGraphics.DrawString("the zodiac.", infoFont, infoBrush, 20, 180);

            }
            else
            {
                //Music
                spaceMusic.Play();

                //Setup
                Pen redPen = new Pen(Color.DarkTurquoise, 7);
                Pen whitePen = new Pen(Color.White, 1);

                Font largeFont = new Font("Magneto", 72, FontStyle.Bold);
                Font smallFont = new Font("Magneto", 36, FontStyle.Bold);
                Font tinyFont = new Font("Impact", 16, FontStyle.Regular);

                SolidBrush blueBrush = new SolidBrush(Color.DarkBlue);
                SolidBrush lightBlueBrush = new SolidBrush(Color.LightBlue);
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                SolidBrush blackBrush = new SolidBrush(Color.DarkGray);

                //Title
                formGraphics.DrawArc(redPen, 60, 20, 500, 500, 90, 360);

                formGraphics.DrawEllipse(whitePen, 63, 23, 494, 494);

                formGraphics.FillEllipse(whiteBrush, 63, 23, 494, 494);

                formGraphics.DrawString("S", largeFont, blueBrush, 80, 70);
                formGraphics.DrawString("corpius", smallFont, lightBlueBrush, 190, 130);
                formGraphics.DrawString("By: Max Senez", tinyFont, blackBrush, 130, 210);//
                
                flag += 1;
            }



        }
    }
}
