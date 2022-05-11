namespace sample_3_6 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
      this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
      this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
      this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
      this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "Create MDI Child";
      this.barButtonItem1.Id = 0;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
      // 
      // barSubItem1
      // 
      this.barSubItem1.Caption = "&File";
      this.barSubItem1.Id = 1;
      this.barSubItem1.Name = "barSubItem1";
      // 
      // barSubItem2
      // 
      this.barSubItem2.Caption = "&View";
      this.barSubItem2.Id = 2;
      this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3, true)});
      this.barSubItem2.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
      this.barSubItem2.Name = "barSubItem2";
      // 
      // barButtonItem2
      // 
      this.barButtonItem2.Caption = "First Main Menu Button";
      this.barButtonItem2.Id = 3;
      this.barButtonItem2.Name = "barButtonItem2";
      // 
      // barButtonItem3
      // 
      this.barButtonItem3.Caption = "Button At End";
      this.barButtonItem3.Id = 4;
      this.barButtonItem3.MergeOrder = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      // 
      // barSubItem3
      // 
      this.barSubItem3.Caption = "Window";
      this.barSubItem3.Id = 5;
      this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barMdiChildrenListItem1)});
      this.barSubItem3.Name = "barSubItem3";
      // 
      // barMdiChildrenListItem1
      // 
      this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
      this.barMdiChildrenListItem1.Id = 6;
      this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barSubItem1,
            this.barSubItem2,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barSubItem3,
            this.barMdiChildrenListItem1,
            this.barButtonItem4});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 2;
      this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbonControl1.Size = new System.Drawing.Size(825, 158);
      this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
      // 
      // barButtonItem4
      // 
      this.barButtonItem4.Caption = "Create Second MDI Child";
      this.barButtonItem4.Id = 1;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup3});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "MainMenu";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "File";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
      this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3, true);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "View";
      // 
      // ribbonPageGroup4
      // 
      this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
      this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem4);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup4.Text = "Tools";
      // 
      // ribbonPageGroup5
      // 
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup5.Text = "Custom 5";
      // 
      // ribbonPageGroup3
      // 
      this.ribbonPageGroup3.ItemLinks.Add(this.barMdiChildrenListItem1);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup3.Text = "Window";
      // 
      // ribbonStatusBar1
      // 
      this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 429);
      this.ribbonStatusBar1.Name = "ribbonStatusBar1";
      this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
      this.ribbonStatusBar1.Size = new System.Drawing.Size(825, 24);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(825, 453);
      this.Controls.Add(this.ribbonStatusBar1);
      this.Controls.Add(this.ribbonControl1);
      this.IsMdiContainer = true;
      this.Name = "Form1";
      this.Ribbon = this.ribbonControl1;
      this.StatusBar = this.ribbonStatusBar1;
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.BarSubItem barSubItem1;
    private DevExpress.XtraBars.BarSubItem barSubItem2;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    private DevExpress.XtraBars.BarSubItem barSubItem3;
    private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem4;
  }
}

