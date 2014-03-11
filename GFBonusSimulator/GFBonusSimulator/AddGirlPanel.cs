using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GFBonusSimulator
{
	public partial class AddGirlPanel : Panel
	{
		private Label girlNameLabel = new Label();		// ガール名を表示するラベル
		private Button addButton = new Button();		// デッキにガールを追加する処理を行うボタン
		public Girl girlData = new Girl();				// このパネルと関連付けられたガール情報


		/// <summary>
		/// 保持しているガール情報のプロパティ
		/// </summary>
		public Girl GirlData
		{
			get
			{
				return this.girlData;
			}

			set
			{
				this.girlData = value;
				girlNameLabel.Text = ( value != null ) ? value.Name : "----------";
			}
		}


		/// <summary>
		/// コンストラクタ
		/// </summary>
		public AddGirlPanel()
		{
			// ラベルの設定
			girlNameLabel.Location = new Point( 10, 6 );
			girlNameLabel.Text = "----------";

			// ボタンの設定
			addButton.Location = new Point( 130, 0 );
			addButton.Width = 30;
			addButton.Text = "→";
			addButton.Click += addButton_Click;

			// パネルにコントロールを追加
			this.Controls.Add( girlNameLabel );
			this.Controls.Add( addButton );

			// パネルの設定
			this.Size = new Size( 170, 25 );
			//this.BorderStyle = BorderStyle.FixedSingle;		// 境界線を表示
		}


		/// <summary>
		/// クリック時のイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void addButton_Click( object sender, EventArgs e )
		{
			// ガールデータを持っていなかった場合は、何もしない
			if( girlData == null )
			{
				return;
			}

			var parentMainForm = this.Parent as MainForm;		// ダウンキャスト

			// メインフォームへのダウンキャストに成功した場合は、センバツ設定中ガール追加処理を呼び出す
			if( parentMainForm != null )
			{
				parentMainForm.AddSenbutsuGirl( this );
			}
		}
	}
}