﻿namespace EATON_MONITOR_55
{
    partial class Circle
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PA_Circle = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PA_Circle
            // 
            this.PA_Circle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PA_Circle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PA_Circle.Location = new System.Drawing.Point(0, 0);
            this.PA_Circle.Margin = new System.Windows.Forms.Padding(0);
            this.PA_Circle.Name = "PA_Circle";
            this.PA_Circle.Size = new System.Drawing.Size(80, 50);
            this.PA_Circle.TabIndex = 0;
            this.PA_Circle.Paint += new System.Windows.Forms.PaintEventHandler(this.PA_Circle_Paint);
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.PA_Circle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Circle";
            this.Size = new System.Drawing.Size(80, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PA_Circle;
    }
}
