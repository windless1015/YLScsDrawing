using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //orientation
        int cameraX=0, cameraY=0, cameraZ=0, cubeX=0, cubeY=0, cubeZ=0;

        YLScsDrawing.Drawing3d.Cuboid cub = new YLScsDrawing.Drawing3d.Cuboid(150, 150, 150);
        YLScsDrawing.Drawing3d.Camera cam = new YLScsDrawing.Drawing3d.Camera();

        private void Form1_Load(object sender, EventArgs e)
        {
            cub.Center = new YLScsDrawing.Drawing3d.Point3d(400, 240, 0);

            cam.Location = new YLScsDrawing.Drawing3d.Point3d(400, 240, -500);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            cub.Draw(e.Graphics, cam);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cubeX += 5;
            labelCrX.Text = cubeX.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(1, 0, 0), 5*Math.PI/180.0);
            cub.RotateAt(cub.Center, q);
            Invalidate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cubeX -= 5;
            labelCrX.Text = cubeX.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(1, 0, 0), -5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);
            Invalidate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cubeY+= 5;
            labelCrY.Text = cubeY.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(0, 1, 0), 5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);
            Invalidate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cubeY -= 5;
            labelCrY.Text = cubeY.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(0, 1, 0), -5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);
            Invalidate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cubeZ += 5;
            labelCrZ.Text = cubeZ.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(0, 0, 1), 5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);
            Invalidate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cubeZ -= 5;
            labelCrZ.Text = cubeZ.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(0, 0, 1), -5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cam.MoveLeft(10);
            Invalidate();
            labelMx.Text = cam.Location.X.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cam.MoveRight(10);
            Invalidate();
            labelMx.Text = cam.Location.X.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cam.MoveUp(10);
            Invalidate();
            labelMy.Text = cam.Location.Y.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cam.MoveDown(10);
            Invalidate();
            labelMy.Text = cam.Location.Y.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cam.MoveIn(10);
            Invalidate();
            labelMz.Text = cam.Location.Z.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cam.MoveOut(10);
            Invalidate();
            labelMz.Text = cam.Location.Z.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            cameraY -= 1;
            labelMrY.Text = cameraY.ToString();
            cam.TurnLeft(1);
            Invalidate();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cameraY += 1;
            labelMrY.Text = cameraY.ToString();
            cam.TurnRight(1);
            Invalidate();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            cameraX -= 1;
            labelMrX.Text = cameraX.ToString();
            cam.TurnUp(1);
            Invalidate();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cameraX+= 1;
            labelMrX.Text = cameraX.ToString();
            cam.TurnDown(1);
            Invalidate();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            cameraZ += 5;
            labelMrZ.Text = cameraZ.ToString();
            cam.Roll(-5);
            Invalidate();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            cameraZ -= 5;
            labelMrZ.Text = cameraZ.ToString();
            cam.Roll(5);
            Invalidate();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cub = new YLScsDrawing.Drawing3d.Cuboid(150, 150, 150);
            cam = new YLScsDrawing.Drawing3d.Camera();
            cub.Center = new YLScsDrawing.Drawing3d.Point3d(400, 240, 0);
            cam.Location = new YLScsDrawing.Drawing3d.Point3d(400, 240, -500);
            Invalidate();
            i = 0;
            bmp = new Bitmap[6];
            labelMx.Text = cam.Location.X.ToString();
            labelMy.Text = cam.Location.Y.ToString();
            labelMz.Text = cam.Location.Z.ToString();
            labelCx.Text = cub.Center.X.ToString();
            labelCy.Text = cub.Center.Y.ToString();
            labelCz.Text = cub.Center.Z.ToString();
            cameraX = 0; cameraY = 0; cameraZ = 0;  cubeX = 0; cubeY = 0; cubeZ = 0;
            labelCrX.Text = "0";
            labelCrY.Text = "0";
            labelCrZ.Text = "0";
            labelMrX.Text = "0";
            labelMrY.Text = "0";
            labelMrZ.Text = "0";
        }

        Bitmap[] bmp = new Bitmap[6];
        int i = 0;
        private void button13_Click(object sender, EventArgs e)
        {
            if (i == 6) return;
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                bmp[i] = new Bitmap(o.FileName);
                i++;
            }
            cub.FaceImageArray = bmp;
            cub.DrawingLine = false;
            cub.DrawingImage = true;
            cub.FillingFace = true;
            Invalidate();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            cub.Center = new YLScsDrawing.Drawing3d.Point3d(cub.Center.X - 5, cub.Center.Y, cub.Center.Z);
            labelCx.Text = cub.Center.X.ToString();
            Invalidate();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            cub.Center = new YLScsDrawing.Drawing3d.Point3d(cub.Center.X+ 5, cub.Center.Y, cub.Center.Z);
            labelCx.Text = cub.Center.X.ToString();
            Invalidate();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            cub.Center = new YLScsDrawing.Drawing3d.Point3d(cub.Center.X, cub.Center.Y-5, cub.Center.Z);
            labelCy.Text = cub.Center.Y.ToString();
            Invalidate();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            cub.Center = new YLScsDrawing.Drawing3d.Point3d(cub.Center.X, cub.Center.Y + 5, cub.Center.Z);
            labelCy.Text = cub.Center.Y.ToString();
            Invalidate();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            cub.Center = new YLScsDrawing.Drawing3d.Point3d(cub.Center.X, cub.Center.Y , cub.Center.Z+5);
            labelCz.Text = cub.Center.Z.ToString();
            Invalidate();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            cub.Center = new YLScsDrawing.Drawing3d.Point3d(cub.Center.X, cub.Center.Y, cub.Center.Z - 5);
            labelCz.Text = cub.Center.Z.ToString();
            Invalidate();
        }
    }
}