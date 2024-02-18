namespace ERregulator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblGameDir;
            System.Windows.Forms.Label lblSeed;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.cbxBullets = new System.Windows.Forms.CheckBox();
            this.cbxRings = new System.Windows.Forms.CheckBox();
            this.cbxWeapons = new System.Windows.Forms.CheckBox();
            this.projectilesGroupBox = new System.Windows.Forms.GroupBox();
            this.cbxBulletsPlus = new System.Windows.Forms.CheckBox();
            this.cbxArmor = new System.Windows.Forms.CheckBox();
            this.armorGroupBox = new System.Windows.Forms.GroupBox();
            this.armorRandomizeWeight = new System.Windows.Forms.CheckBox();
            this.weaponGroupBox = new System.Windows.Forms.GroupBox();
            this.weaponRandomizeAttributes = new System.Windows.Forms.CheckBox();
            this.weaponKeepArtsOfWar = new System.Windows.Forms.CheckBox();
            this.weaponKeepMovesets = new System.Windows.Forms.CheckBox();
            this.weaponSeperateShields = new System.Windows.Forms.CheckBox();
            this.weaponRandomizeWeight = new System.Windows.Forms.CheckBox();
            this.weaponKeepCategories = new System.Windows.Forms.CheckBox();
            this.cbxOther = new System.Windows.Forms.CheckBox();
            this.cbxHumans = new System.Windows.Forms.CheckBox();
            this.cbxSpells = new System.Windows.Forms.CheckBox();
            this.cbxGoods = new System.Windows.Forms.CheckBox();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.talismanGroupBox = new System.Windows.Forms.GroupBox();
            this.ringsRandomizeWeight = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.fbdGameDir = new System.Windows.Forms.FolderBrowserDialog();
            this.txtGameDir = new System.Windows.Forms.TextBox();
            lblGameDir = new System.Windows.Forms.Label();
            lblSeed = new System.Windows.Forms.Label();
            this.gbxOptions.SuspendLayout();
            this.projectilesGroupBox.SuspendLayout();
            this.armorGroupBox.SuspendLayout();
            this.weaponGroupBox.SuspendLayout();
            this.talismanGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameDir
            // 
            lblGameDir.AutoSize = true;
            lblGameDir.Location = new System.Drawing.Point(16, 11);
            lblGameDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGameDir.Name = "lblGameDir";
            lblGameDir.Size = new System.Drawing.Size(101, 16);
            lblGameDir.TabIndex = 0;
            lblGameDir.Text = "Game Directory";
            // 
            // lblSeed
            // 
            lblSeed.AutoSize = true;
            lblSeed.Location = new System.Drawing.Point(8, 20);
            lblSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSeed.Name = "lblSeed";
            lblSeed.Size = new System.Drawing.Size(222, 16);
            lblSeed.TabIndex = 0;
            lblSeed.Text = "Seed (leave blank for random seed)";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(348, 63);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExplore.Location = new System.Drawing.Point(456, 63);
            this.btnExplore.Margin = new System.Windows.Forms.Padding(4);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(100, 28);
            this.btnExplore.TabIndex = 3;
            this.btnExplore.Text = "Explore";
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandomize.Location = new System.Drawing.Point(672, 63);
            this.btnRandomize.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(100, 28);
            this.btnRandomize.TabIndex = 4;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(564, 63);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(100, 28);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // gbxOptions
            // 
            this.gbxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOptions.Controls.Add(this.cbxBullets);
            this.gbxOptions.Controls.Add(this.cbxRings);
            this.gbxOptions.Controls.Add(this.cbxWeapons);
            this.gbxOptions.Controls.Add(this.projectilesGroupBox);
            this.gbxOptions.Controls.Add(this.cbxArmor);
            this.gbxOptions.Controls.Add(this.armorGroupBox);
            this.gbxOptions.Controls.Add(this.weaponGroupBox);
            this.gbxOptions.Controls.Add(this.cbxOther);
            this.gbxOptions.Controls.Add(this.cbxHumans);
            this.gbxOptions.Controls.Add(this.cbxSpells);
            this.gbxOptions.Controls.Add(this.cbxGoods);
            this.gbxOptions.Controls.Add(this.txtSeed);
            this.gbxOptions.Controls.Add(lblSeed);
            this.gbxOptions.Controls.Add(this.talismanGroupBox);
            this.gbxOptions.Location = new System.Drawing.Point(16, 98);
            this.gbxOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Padding = new System.Windows.Forms.Padding(4);
            this.gbxOptions.Size = new System.Drawing.Size(756, 561);
            this.gbxOptions.TabIndex = 6;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Options";
            // 
            // cbxBullets
            // 
            this.cbxBullets.AutoSize = true;
            this.cbxBullets.Checked = global::ERregulator.Properties.Settings.Default.DoBullets;
            this.cbxBullets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxBullets.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "DoBullets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxBullets.Location = new System.Drawing.Point(13, 372);
            this.cbxBullets.Margin = new System.Windows.Forms.Padding(4);
            this.cbxBullets.Name = "cbxBullets";
            this.cbxBullets.Size = new System.Drawing.Size(92, 20);
            this.cbxBullets.TabIndex = 7;
            this.cbxBullets.Text = "Projectiles";
            this.toolTip1.SetToolTip(this.cbxBullets, "Randomizes projectile behavior.");
            this.cbxBullets.UseVisualStyleBackColor = true;
            this.cbxBullets.CheckedChanged += new System.EventHandler(this.cbxBullets_CheckedChanged);
            // 
            // cbxRings
            // 
            this.cbxRings.AutoSize = true;
            this.cbxRings.Checked = global::ERregulator.Properties.Settings.Default.DoRings;
            this.cbxRings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRings.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "DoRings", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxRings.Location = new System.Drawing.Point(14, 306);
            this.cbxRings.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRings.Name = "cbxRings";
            this.cbxRings.Size = new System.Drawing.Size(92, 20);
            this.cbxRings.TabIndex = 4;
            this.cbxRings.Text = "Talismans";
            this.toolTip1.SetToolTip(this.cbxRings, "Randomizes talisman effects.");
            this.cbxRings.UseVisualStyleBackColor = true;
            this.cbxRings.CheckedChanged += new System.EventHandler(this.cbxRings_CheckedChanged);
            // 
            // cbxWeapons
            // 
            this.cbxWeapons.AutoSize = true;
            this.cbxWeapons.Checked = global::ERregulator.Properties.Settings.Default.DoWeapons;
            this.cbxWeapons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxWeapons.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "DoWeapons", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxWeapons.Location = new System.Drawing.Point(14, 136);
            this.cbxWeapons.Margin = new System.Windows.Forms.Padding(4);
            this.cbxWeapons.Name = "cbxWeapons";
            this.cbxWeapons.Size = new System.Drawing.Size(88, 20);
            this.cbxWeapons.TabIndex = 3;
            this.cbxWeapons.Text = "Weapons";
            this.toolTip1.SetToolTip(this.cbxWeapons, "Randomizes weapon movesets, weapon arts and stats.");
            this.cbxWeapons.UseVisualStyleBackColor = true;
            this.cbxWeapons.CheckedChanged += new System.EventHandler(this.cbxWeapons_CheckedChanged);
            // 
            // projectilesGroupBox
            // 
            this.projectilesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectilesGroupBox.Controls.Add(this.cbxBulletsPlus);
            this.projectilesGroupBox.Location = new System.Drawing.Point(7, 373);
            this.projectilesGroupBox.Name = "projectilesGroupBox";
            this.projectilesGroupBox.Size = new System.Drawing.Size(740, 60);
            this.projectilesGroupBox.TabIndex = 19;
            this.projectilesGroupBox.TabStop = false;
            // 
            // cbxBulletsPlus
            // 
            this.cbxBulletsPlus.AutoSize = true;
            this.cbxBulletsPlus.Checked = global::ERregulator.Properties.Settings.Default.BulletsPlus;
            this.cbxBulletsPlus.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "BulletsPlus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxBulletsPlus.Location = new System.Drawing.Point(7, 27);
            this.cbxBulletsPlus.Margin = new System.Windows.Forms.Padding(4);
            this.cbxBulletsPlus.Name = "cbxBulletsPlus";
            this.cbxBulletsPlus.Size = new System.Drawing.Size(84, 20);
            this.cbxBulletsPlus.TabIndex = 11;
            this.cbxBulletsPlus.Text = "No Limits";
            this.toolTip1.SetToolTip(this.cbxBulletsPlus, "Off: Randomize projectiles using default randomization.\r\nOn: Uses a different met" +
        "hod of randomization that will massively increase projectile creation, use with " +
        "caution.");
            this.cbxBulletsPlus.UseVisualStyleBackColor = true;
            // 
            // cbxArmor
            // 
            this.cbxArmor.AutoSize = true;
            this.cbxArmor.Checked = global::ERregulator.Properties.Settings.Default.DoArmor;
            this.cbxArmor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxArmor.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "DoArmor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxArmor.Location = new System.Drawing.Point(14, 70);
            this.cbxArmor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxArmor.Name = "cbxArmor";
            this.cbxArmor.Size = new System.Drawing.Size(65, 20);
            this.cbxArmor.TabIndex = 2;
            this.cbxArmor.Text = "Armor";
            this.toolTip1.SetToolTip(this.cbxArmor, "Randomizes armor stats.");
            this.cbxArmor.UseVisualStyleBackColor = true;
            this.cbxArmor.CheckedChanged += new System.EventHandler(this.cbxArmor_CheckedChanged);
            // 
            // armorGroupBox
            // 
            this.armorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armorGroupBox.Controls.Add(this.armorRandomizeWeight);
            this.armorGroupBox.Location = new System.Drawing.Point(7, 72);
            this.armorGroupBox.Name = "armorGroupBox";
            this.armorGroupBox.Size = new System.Drawing.Size(740, 60);
            this.armorGroupBox.TabIndex = 17;
            this.armorGroupBox.TabStop = false;
            // 
            // armorRandomizeWeight
            // 
            this.armorRandomizeWeight.AutoSize = true;
            this.armorRandomizeWeight.Checked = global::ERregulator.Properties.Settings.Default.ArmorRandomizeWeight;
            this.armorRandomizeWeight.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "ArmorRandomizeWeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.armorRandomizeWeight.Location = new System.Drawing.Point(7, 27);
            this.armorRandomizeWeight.Name = "armorRandomizeWeight";
            this.armorRandomizeWeight.Size = new System.Drawing.Size(143, 20);
            this.armorRandomizeWeight.TabIndex = 12;
            this.armorRandomizeWeight.Text = "Randomize Weight";
            this.toolTip1.SetToolTip(this.armorRandomizeWeight, "On: Armor will have random weights, this can be quite unfair especially in the ea" +
        "rly game.\r\nOff: Armor will have their original weight.\r\n");
            this.armorRandomizeWeight.UseVisualStyleBackColor = true;
            // 
            // weaponGroupBox
            // 
            this.weaponGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weaponGroupBox.Controls.Add(this.weaponRandomizeAttributes);
            this.weaponGroupBox.Controls.Add(this.weaponKeepArtsOfWar);
            this.weaponGroupBox.Controls.Add(this.weaponKeepMovesets);
            this.weaponGroupBox.Controls.Add(this.weaponSeperateShields);
            this.weaponGroupBox.Controls.Add(this.weaponRandomizeWeight);
            this.weaponGroupBox.Controls.Add(this.weaponKeepCategories);
            this.weaponGroupBox.Location = new System.Drawing.Point(7, 136);
            this.weaponGroupBox.Name = "weaponGroupBox";
            this.weaponGroupBox.Size = new System.Drawing.Size(740, 163);
            this.weaponGroupBox.TabIndex = 16;
            this.weaponGroupBox.TabStop = false;
            // 
            // weaponRandomizeAttributes
            // 
            this.weaponRandomizeAttributes.AutoSize = true;
            this.weaponRandomizeAttributes.Checked = global::ERregulator.Properties.Settings.Default.WeaponRandomizeAttributes;
            this.weaponRandomizeAttributes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weaponRandomizeAttributes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "WeaponRandomizeAttributes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.weaponRandomizeAttributes.Location = new System.Drawing.Point(7, 53);
            this.weaponRandomizeAttributes.Name = "weaponRandomizeAttributes";
            this.weaponRandomizeAttributes.Size = new System.Drawing.Size(156, 20);
            this.weaponRandomizeAttributes.TabIndex = 18;
            this.weaponRandomizeAttributes.Text = "Randomize Attributes";
            this.toolTip1.SetToolTip(this.weaponRandomizeAttributes, "On: Weapons will have random attributes and attribute requirements.\r\nOff: Weapons" +
        " will have their attributes and attribute requirements.");
            this.weaponRandomizeAttributes.UseVisualStyleBackColor = true;
            // 
            // weaponKeepArtsOfWar
            // 
            this.weaponKeepArtsOfWar.AutoSize = true;
            this.weaponKeepArtsOfWar.Checked = global::ERregulator.Properties.Settings.Default.WeaponKeepArtsOfWar;
            this.weaponKeepArtsOfWar.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "WeaponKeepArtsOfWar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.weaponKeepArtsOfWar.Location = new System.Drawing.Point(7, 132);
            this.weaponKeepArtsOfWar.Name = "weaponKeepArtsOfWar";
            this.weaponKeepArtsOfWar.Size = new System.Drawing.Size(129, 20);
            this.weaponKeepArtsOfWar.TabIndex = 17;
            this.weaponKeepArtsOfWar.Text = "Keep Arts of War";
            this.toolTip1.SetToolTip(this.weaponKeepArtsOfWar, "On: All weapons will keep their default arts of war.\r\nOff: All weapons can have a" +
        "rts of war from other weapons.");
            this.weaponKeepArtsOfWar.UseVisualStyleBackColor = true;
            // 
            // weaponKeepMovesets
            // 
            this.weaponKeepMovesets.AutoSize = true;
            this.weaponKeepMovesets.Checked = global::ERregulator.Properties.Settings.Default.WeaponKeepMovesets;
            this.weaponKeepMovesets.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "WeaponKeepMovesets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.weaponKeepMovesets.Location = new System.Drawing.Point(7, 106);
            this.weaponKeepMovesets.Name = "weaponKeepMovesets";
            this.weaponKeepMovesets.Size = new System.Drawing.Size(123, 20);
            this.weaponKeepMovesets.TabIndex = 16;
            this.weaponKeepMovesets.Text = "Keep Movesets";
            this.toolTip1.SetToolTip(this.weaponKeepMovesets, "On: All weapons will have their default movesets.\r\nOff: Weapons can have movesets" +
        " from other weapons.");
            this.weaponKeepMovesets.UseVisualStyleBackColor = true;
            // 
            // weaponSeperateShields
            // 
            this.weaponSeperateShields.AutoSize = true;
            this.weaponSeperateShields.Checked = global::ERregulator.Properties.Settings.Default.WeaponSeperateShields;
            this.weaponSeperateShields.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "WeaponSeperateShields", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.weaponSeperateShields.Enabled = false;
            this.weaponSeperateShields.Location = new System.Drawing.Point(184, 79);
            this.weaponSeperateShields.Name = "weaponSeperateShields";
            this.weaponSeperateShields.Size = new System.Drawing.Size(270, 20);
            this.weaponSeperateShields.TabIndex = 15;
            this.weaponSeperateShields.Text = "Seperate Shields From Melee Weapons";
            this.toolTip1.SetToolTip(this.weaponSeperateShields, "On: Shields and melee weapons will not share movesets, weapon arts and stats.\r\nOf" +
        "f: Shields and melee weapons can share movesets, weapon arts and stats.");
            this.weaponSeperateShields.UseVisualStyleBackColor = true;
            // 
            // weaponRandomizeWeight
            // 
            this.weaponRandomizeWeight.AutoSize = true;
            this.weaponRandomizeWeight.Checked = global::ERregulator.Properties.Settings.Default.WeaponRandomizeWeight;
            this.weaponRandomizeWeight.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "WeaponRandomizeWeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.weaponRandomizeWeight.Location = new System.Drawing.Point(7, 27);
            this.weaponRandomizeWeight.Name = "weaponRandomizeWeight";
            this.weaponRandomizeWeight.Size = new System.Drawing.Size(143, 20);
            this.weaponRandomizeWeight.TabIndex = 13;
            this.weaponRandomizeWeight.Text = "Randomize Weight";
            this.toolTip1.SetToolTip(this.weaponRandomizeWeight, "On: Weapons will have random weights, this can be quite unfair especially in the " +
        "early game.\r\nOff: Weapons will have their original weight.");
            this.weaponRandomizeWeight.UseVisualStyleBackColor = true;
            // 
            // weaponKeepCategories
            // 
            this.weaponKeepCategories.AutoSize = true;
            this.weaponKeepCategories.Checked = global::ERregulator.Properties.Settings.Default.WeaponKeepCategories;
            this.weaponKeepCategories.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "WeaponKeepCategories", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.weaponKeepCategories.Location = new System.Drawing.Point(7, 79);
            this.weaponKeepCategories.Name = "weaponKeepCategories";
            this.weaponKeepCategories.Size = new System.Drawing.Size(130, 20);
            this.weaponKeepCategories.TabIndex = 14;
            this.weaponKeepCategories.Text = "Keep Categories";
            this.toolTip1.SetToolTip(this.weaponKeepCategories, "On: Movesets, weapon arts and stats will be shuffled per weapon category.\r\nOff: M" +
        "elee weapons can share movesets, weapon arts and stats with ranged/magic weapons" +
        ", and vice versa.");
            this.weaponKeepCategories.UseVisualStyleBackColor = true;
            this.weaponKeepCategories.CheckedChanged += new System.EventHandler(this.weaponKeepCategories_CheckedChanged);
            // 
            // cbxOther
            // 
            this.cbxOther.AutoSize = true;
            this.cbxOther.Checked = global::ERregulator.Properties.Settings.Default.DoOther;
            this.cbxOther.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOther.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "DoOther", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxOther.Location = new System.Drawing.Point(13, 525);
            this.cbxOther.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOther.Name = "cbxOther";
            this.cbxOther.Size = new System.Drawing.Size(61, 20);
            this.cbxOther.TabIndex = 9;
            this.cbxOther.Text = "Other";
            this.toolTip1.SetToolTip(this.cbxOther, "Randomizes various effects (weapon arts, decals, phantoms, weather).");
            this.cbxOther.UseVisualStyleBackColor = true;
            // 
            // cbxHumans
            // 
            this.cbxHumans.AutoSize = true;
            this.cbxHumans.Checked = global::ERregulator.Properties.Settings.Default.DoHumans;
            this.cbxHumans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHumans.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "DoHumans", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxHumans.Location = new System.Drawing.Point(13, 496);
            this.cbxHumans.Margin = new System.Windows.Forms.Padding(4);
            this.cbxHumans.Name = "cbxHumans";
            this.cbxHumans.Size = new System.Drawing.Size(79, 20);
            this.cbxHumans.TabIndex = 8;
            this.cbxHumans.Text = "Humans";
            this.toolTip1.SetToolTip(this.cbxHumans, "Randomizes character loadouts.");
            this.cbxHumans.UseVisualStyleBackColor = true;
            // 
            // cbxSpells
            // 
            this.cbxSpells.AutoSize = true;
            this.cbxSpells.Checked = global::ERregulator.Properties.Settings.Default.DoSpells;
            this.cbxSpells.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSpells.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "DoSpells", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxSpells.Location = new System.Drawing.Point(13, 468);
            this.cbxSpells.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSpells.Name = "cbxSpells";
            this.cbxSpells.Size = new System.Drawing.Size(67, 20);
            this.cbxSpells.TabIndex = 6;
            this.cbxSpells.Text = "Spells";
            this.toolTip1.SetToolTip(this.cbxSpells, "Randomizes spell effects.");
            this.cbxSpells.UseVisualStyleBackColor = true;
            // 
            // cbxGoods
            // 
            this.cbxGoods.AutoSize = true;
            this.cbxGoods.Checked = global::ERregulator.Properties.Settings.Default.DoGoods;
            this.cbxGoods.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxGoods.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "DoGoods", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxGoods.Location = new System.Drawing.Point(13, 440);
            this.cbxGoods.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGoods.Name = "cbxGoods";
            this.cbxGoods.Size = new System.Drawing.Size(70, 20);
            this.cbxGoods.TabIndex = 5;
            this.cbxGoods.Text = "Goods";
            this.toolTip1.SetToolTip(this.cbxGoods, "Randomizes usable item effects, the flasks and spectral steed whistle will stay t" +
        "he same.");
            this.cbxGoods.UseVisualStyleBackColor = true;
            // 
            // txtSeed
            // 
            this.txtSeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ERregulator.Properties.Settings.Default, "Seed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSeed.Location = new System.Drawing.Point(8, 39);
            this.txtSeed.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(739, 22);
            this.txtSeed.TabIndex = 1;
            this.txtSeed.Text = global::ERregulator.Properties.Settings.Default.Seed;
            this.toolTip1.SetToolTip(this.txtSeed, "Sharing a seed lets you and another player get the same result from randomization" +
        ".");
            // 
            // talismanGroupBox
            // 
            this.talismanGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.talismanGroupBox.Controls.Add(this.ringsRandomizeWeight);
            this.talismanGroupBox.Location = new System.Drawing.Point(7, 309);
            this.talismanGroupBox.Name = "talismanGroupBox";
            this.talismanGroupBox.Size = new System.Drawing.Size(740, 60);
            this.talismanGroupBox.TabIndex = 18;
            this.talismanGroupBox.TabStop = false;
            // 
            // ringsRandomizeWeight
            // 
            this.ringsRandomizeWeight.AutoSize = true;
            this.ringsRandomizeWeight.Checked = global::ERregulator.Properties.Settings.Default.TalismansRandomizeWeight;
            this.ringsRandomizeWeight.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ERregulator.Properties.Settings.Default, "TalismansRandomizeWeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ringsRandomizeWeight.Location = new System.Drawing.Point(7, 24);
            this.ringsRandomizeWeight.Name = "ringsRandomizeWeight";
            this.ringsRandomizeWeight.Size = new System.Drawing.Size(143, 20);
            this.ringsRandomizeWeight.TabIndex = 15;
            this.ringsRandomizeWeight.Text = "Randomize Weight";
            this.toolTip1.SetToolTip(this.ringsRandomizeWeight, "On: Talismans will have random weights, this can be quite unfair especially in th" +
        "e early game.\r\nOff: Talismans will have their original weight.");
            this.ringsRandomizeWeight.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Location = new System.Drawing.Point(16, 65);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(323, 22);
            this.txtStatus.TabIndex = 7;
            // 
            // fbdGameDir
            // 
            this.fbdGameDir.Description = "Select your Dark Souls III install directory...";
            this.fbdGameDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbdGameDir.ShowNewFolderButton = false;
            // 
            // txtGameDir
            // 
            this.txtGameDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ERregulator.Properties.Settings.Default, "GameDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGameDir.Location = new System.Drawing.Point(16, 31);
            this.txtGameDir.Margin = new System.Windows.Forms.Padding(4);
            this.txtGameDir.Name = "txtGameDir";
            this.txtGameDir.Size = new System.Drawing.Size(755, 22);
            this.txtGameDir.TabIndex = 1;
            this.txtGameDir.Text = global::ERregulator.Properties.Settings.Default.GameDir;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 673);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.gbxOptions);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtGameDir);
            this.Controls.Add(lblGameDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(806, 720);
            this.Name = "FormMain";
            this.Text = "ERregulator<version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            this.projectilesGroupBox.ResumeLayout(false);
            this.projectilesGroupBox.PerformLayout();
            this.armorGroupBox.ResumeLayout(false);
            this.armorGroupBox.PerformLayout();
            this.weaponGroupBox.ResumeLayout(false);
            this.weaponGroupBox.PerformLayout();
            this.talismanGroupBox.ResumeLayout(false);
            this.talismanGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbxOther;
        private System.Windows.Forms.CheckBox cbxHumans;
        private System.Windows.Forms.CheckBox cbxBullets;
        private System.Windows.Forms.CheckBox cbxSpells;
        private System.Windows.Forms.CheckBox cbxGoods;
        private System.Windows.Forms.CheckBox cbxRings;
        private System.Windows.Forms.CheckBox cbxWeapons;
        private System.Windows.Forms.CheckBox cbxArmor;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox gbxOptions;
        private System.Windows.Forms.FolderBrowserDialog fbdGameDir;
        private System.Windows.Forms.CheckBox cbxBulletsPlus;
        private System.Windows.Forms.CheckBox weaponRandomizeWeight;
        private System.Windows.Forms.CheckBox armorRandomizeWeight;
        private System.Windows.Forms.CheckBox weaponKeepCategories;
        private System.Windows.Forms.CheckBox ringsRandomizeWeight;
        private System.Windows.Forms.GroupBox weaponGroupBox;
        private System.Windows.Forms.GroupBox armorGroupBox;
        private System.Windows.Forms.CheckBox weaponSeperateShields;
        private System.Windows.Forms.GroupBox talismanGroupBox;
        private System.Windows.Forms.GroupBox projectilesGroupBox;
        private System.Windows.Forms.CheckBox weaponKeepMovesets;
        private System.Windows.Forms.CheckBox weaponKeepArtsOfWar;
        private System.Windows.Forms.CheckBox weaponRandomizeAttributes;
    }
}

