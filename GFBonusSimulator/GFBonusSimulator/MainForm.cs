using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GFBonusSimulator
{
	/// <summary>
	/// メインフォーム
	/// </summary>
    public partial class MainForm : Form
    {
		const int GIRL_NUM_BY_PAGE = 14;
		const int BONUS_NUM_BY_RAW = 14;

		private Label[] headlines = new Label[3] { new Label(), new Label(), new Label(), };		// 見出しラベル
		private Label[] subtitles = new Label[2] { new Label(), new Label(), };						// 小見出しラベル
		private Label selectedGirlsNumLabel = new Label();											// センバツ設定中ガール数表示ラベル				
		private ComboBox typeComboBox;																// 一覧するガールのタイプを選択するためのコンボボックス
		private ComboBox girlListPageComboBox;														// ガール一覧のページ数を選択するためのコンボボックス
		private ComboBox selectedGirlListPageComboBox;												// センバツ設定中ガール一覧のページ数を選択するためのコンボボックス
		private AddGirlPanel[] addPanels = new AddGirlPanel[GIRL_NUM_BY_PAGE];						// ガール追加ボタン
		private DeleteGirlPanel[] deletePanels = new DeleteGirlPanel[GIRL_NUM_BY_PAGE];				// ガール削除ボタン
		private Label[] activeAtkBonusLabels = new Label[BONUS_NUM_BY_RAW];							// 発動攻援ボーナス名ラベル
		private Label[] activeDefBonusLabels = new Label[BONUS_NUM_BY_RAW];							// 発動守援ボーナス名ラベル

		private IList<Girl> selectedGirls = new List<Girl>();										// センバツ設定中ガール
		private IDictionary<Bonus.eAtk, int> atkBonusCounts = new Dictionary<Bonus.eAtk, int>();	// 攻援センバツボーナスポイントカウント用Dictionary
		private IDictionary<Bonus.eDef, int> defBonusCounts = new Dictionary<Bonus.eDef, int>();	// 守援センバツボーナスポイントカウント用Dictionary



		/// <summary>
		/// コンストラクタ
		/// </summary>
        public MainForm()
        {
			// メンバ変数の初期化
			for( int i = 0; i < ( int )Bonus.eAtk.BONUS_NUM; i++ )
			{
				atkBonusCounts.Add( ( Bonus.eAtk )i, 0 );
			}

			for( int i = 0; i < ( int )Bonus.eDef.BONUS_NUM; i++ )
			{
				defBonusCounts.Add( ( Bonus.eDef )i, 0 );
			}

			for( int i = 0; i < BONUS_NUM_BY_RAW; i++ )
			{
				activeAtkBonusLabels[i] = new Label()
				{
					Location = new Point( 500, 120 + ( 30 * i ) ),
					AutoSize = true,
				};

				activeDefBonusLabels[i] = new Label()
				{
					Location = new Point( 700, 120 + ( 30 * i ) ),
					AutoSize = true,
				};
			}


			// 見出しラベルの設定
			headlines[0].Location = new Point( 10, 10 );
			headlines[0].AutoSize = true;
			headlines[0].Text = "ガール一覧";
			headlines[1].Location = new Point( 260, 10 );
			headlines[1].AutoSize = true;
			headlines[1].Text = "センバツ設定中ガール";
			headlines[2].AutoSize = true;
			headlines[2].Location = new Point( 500, 10 );
			headlines[2].Text = "発動センバツボーナス";

			// 小見出しラベルの設定
			subtitles[0].Location = new Point( 500, 70 );
			subtitles[0].AutoSize = true;
			subtitles[0].Text = "攻援ボーナス" + Environment.NewLine + "――――――――";
			subtitles[1].Location = new Point( 700, 70 );
			subtitles[1].AutoSize = true;
			subtitles[1].Text = "守援ボーナス" + Environment.NewLine + "――――――――";

			// センバツ設定中ガール数表示ラベル
			selectedGirlsNumLabel.Location = new Point( 260, 40 );
			selectedGirlsNumLabel.AutoSize = true;
			selectedGirlsNumLabel.Text = "現在の人数 " + selectedGirls.Count + " 人";


			// ガール追加パネルの設定（コンボボックスの設定より先にやる必要がある）
			for( int i = 0; i < GIRL_NUM_BY_PAGE; i++ )
			{
				addPanels[i] = new AddGirlPanel() { Location = new Point( 10, 120 + ( 30 * i ) ) };
				deletePanels[i] = new DeleteGirlPanel() { Location = new Point( 260, 120 + ( 30 * i ) ) }; 
			}


			// タイプ選択コンボボックスの設定
			typeComboBox = new ComboBox()
			{
				Location = new Point( 10, 40 ),
				DropDownStyle = ComboBoxStyle.DropDownList,
			};

			typeComboBox.Items.Add( "SWEET" );
			typeComboBox.Items.Add( "COOL" );
			typeComboBox.Items.Add( "POP" );
			typeComboBox.SelectedIndex = 0;
			typeComboBox.SelectedIndexChanged += GirlListComboBox_SelectedIndexChaged;


			// ガール一覧ページ選択コンボボックスの設定
			girlListPageComboBox = new ComboBox()
			{
				Location = new Point( 10, 70 ),
				DropDownStyle = ComboBoxStyle.DropDownList,
			};

			girlListPageComboBox.Items.Add( "1" );
			girlListPageComboBox.Items.Add( "2" );
			girlListPageComboBox.Items.Add( "3" );
			girlListPageComboBox.SelectedIndexChanged += GirlListComboBox_SelectedIndexChaged;
			girlListPageComboBox.SelectedIndex = 0;


			// センバツ設定中ガール一覧ページ選択コンボボックスの設定
			selectedGirlListPageComboBox = new ComboBox()
			{
				Location = new Point( 260, 70 ),
				DropDownStyle = ComboBoxStyle.DropDownList,
			};

			selectedGirlListPageComboBox.Items.Add( "1" );
			selectedGirlListPageComboBox.Items.Add( "2" );
			selectedGirlListPageComboBox.Items.Add( "3" );
			selectedGirlListPageComboBox.Items.Add( "4" );
			selectedGirlListPageComboBox.SelectedIndexChanged += SelectedGirlListComboBox_SelectedIndexChaged;
			selectedGirlListPageComboBox.SelectedIndex = 0;


			// フォームにコントロールを追加
			this.Controls.AddRange( headlines );
			this.Controls.AddRange( subtitles );
			this.Controls.Add( selectedGirlsNumLabel );
			this.Controls.Add( typeComboBox );
			this.Controls.Add( girlListPageComboBox );
			this.Controls.Add( selectedGirlListPageComboBox );
			this.Controls.AddRange( addPanels );
			this.Controls.AddRange( deletePanels );
			this.Controls.AddRange( activeAtkBonusLabels );
			this.Controls.AddRange( activeDefBonusLabels );
			

			// フォームの設定
			this.Size = new Size( 900, 600 );
			this.Text = "GF(仮) センバツボーナスシミュレータ";
        }



		/// <summary>
		/// センバツ設定中ガール追加処理
		/// </summary>
		/// <param name="addGirlPanel"></param>
		public void AddSenbutsuGirl( AddGirlPanel addGirlPanel )
		{
			// 既にセンバツ設定中のガールが上限に達していた場合は、早期return
			if( deletePanels.Length >= GIRL_NUM_BY_PAGE * selectedGirlListPageComboBox.Items.Count )
			{
				return;
			}

			Girl girlData = addGirlPanel.GirlData;
			selectedGirls.Add( girlData );
			
			// ガールの保持する攻援センバツボーナスの数だけ繰り返す
			foreach( var x in girlData.atkBonus )
			{
				// NONEが来た場合は早期にbreakする
				if( x == Bonus.eAtk.NONE )
				{
					break;
				}

				atkBonusCounts[x]++;
			}

			// ガールの保持する守援センバツボーナスの数だけ繰り返す
			foreach( var x in girlData.defBonus )
			{
				// NONEが来た場合は早期にbreakする
				if( x == Bonus.eDef.NONE )
				{
					break;
				}

				defBonusCounts[x]++;
			}

			// センバツ設定中ガール一覧、発生センバツボーナス一覧を更新
			refreshSelectedGirlsList(); 
			refreshBonusList();
		}



		/// <summary>
		/// センバツ設定中ガール除外処理
		/// </summary>
		/// <param name="deleteGirlPanel"></param>
		public void RemoveSenbutsuGirl( DeleteGirlPanel deleteGirlPanel )
		{
			Girl girlData = deleteGirlPanel.GirlData;
			
			// ガールの保持する攻援センバツボーナスの数だけ繰り返す
			foreach( var x in girlData.atkBonus )
			{
				// NONEが来た場合は早期にbreakする
				if( x == Bonus.eAtk.NONE )
				{
					break;
				}

				atkBonusCounts[x]--;
			}

			// ガールの保持する守援センバツボーナスの数だけ繰り返す
			foreach( var x in girlData.defBonus )
			{
				// NONEが来た場合は早期にbreakする
				if( x == Bonus.eDef.NONE )
				{
					break;
				}

				defBonusCounts[x]--;
			}

			// 該当ガールをセンバツ設定中ガール一覧から除外
			selectedGirls.Remove( girlData );			

			// センバツ設定中ガール一覧、発生センバツボーナス一覧を更新
			refreshSelectedGirlsList();
			refreshBonusList();
		}



		/// <summary>
		/// センバツ設定中ガール一覧表示更新関数
		/// </summary>
		private void refreshSelectedGirlsList()
		{
			int girlRefOffset = selectedGirlListPageComboBox.SelectedIndex * GIRL_NUM_BY_PAGE;	// 現在のページ数に応じて、参照するガールデータの範囲を決定するためのオフセットを計算
			int loopNum = GIRL_NUM_BY_PAGE;														// ガールデータリストから、ガールデータを取り出す回数

			// ガールリストを配列外参照する危険性がある場合、ループ回数を再計算
			if( girlRefOffset + GIRL_NUM_BY_PAGE > selectedGirls.Count )
			{
				loopNum = selectedGirls.Count - girlRefOffset;
				loopNum = Math.Max( loopNum, 0 );				// loopNumが負数になっていたら、0に修正する
			}

			// ガールデータをガール追加パネルにセットする
			for( int i = 0; i < loopNum; i++ )
			{
				deletePanels[i].GirlData = selectedGirls[i + girlRefOffset];
			}

			// 上記のループでガールが割り当てられなかったガール追加ボタンには、nullを渡す
			for( int i = 0; i < GIRL_NUM_BY_PAGE - loopNum; i++ )
			{
				deletePanels[GIRL_NUM_BY_PAGE - i - 1].GirlData = null;
			}

			selectedGirlsNumLabel.Text = "現在の人数 " + selectedGirls.Count + " 人";
		}



		/// <summary>
		/// 発生センバツボーナス表示更新関数
		/// </summary>
		private void refreshBonusList()
		{
			var sortedList_1 = new List<KeyValuePair<Bonus.eAtk, int>>( atkBonusCounts );
			sortedList_1.Sort( ( x, y ) => y.Value - x.Value );

			int loopCount = 0;
			foreach( var x in sortedList_1 )
			{
				string str = Bonus.atkName[( int )x.Key] + " ( " + x.Value + " )";
				activeAtkBonusLabels[loopCount].Text = str;

				if( ++loopCount >= activeAtkBonusLabels.Length )
				{
					break;
				}
			}

			var sortedList_2 = new List<KeyValuePair<Bonus.eDef, int>>( defBonusCounts );
			sortedList_2.Sort( ( x, y ) => y.Value - x.Value );

			loopCount = 0;
			foreach( var x in sortedList_2 )
			{
				string str = Bonus.defName[( int )x.Key] + " ( " + x.Value + " )";
				activeDefBonusLabels[loopCount].Text = str;

				if( ++loopCount >= activeDefBonusLabels.Length )
				{
					break;
				}
			}
		}



		/// <summary>
		/// ガール一覧コンボボックス項目変更時イベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void GirlListComboBox_SelectedIndexChaged( object sender, EventArgs e )
		{
			Girl[] girlDatas = null;

			// 現在の選択しているタイプに応じて、参照するガールデータリストを決定する
			switch( typeComboBox.SelectedIndex )
			{
				case 0:
					girlDatas = GirlDetabase.sweetGirls;
					break;

				case 1:
					girlDatas = GirlDetabase.coolGirls;
					break;

				case 2:
					girlDatas = GirlDetabase.popGirls;
					break;
			}


			int girlRefOffset = girlListPageComboBox.SelectedIndex * GIRL_NUM_BY_PAGE;	// 現在のページ数に応じて、参照するガールデータの範囲を決定するためのオフセットを計算
			int loopNum = GIRL_NUM_BY_PAGE;										// ガールデータリストから、ガールデータを取り出す回数

			// ガールリストを配列外参照する危険性がある場合、ループ回数を再計算
			if( girlRefOffset + GIRL_NUM_BY_PAGE > girlDatas.Length )
			{
				loopNum = girlDatas.Length - girlRefOffset;
				loopNum = Math.Max( loopNum, 0 );				// loopNumが負数になっていたら、0に修正する
			}

			// ガールデータをガール追加ボタンにセットする
			for( int i = 0; i < loopNum; i++ )
			{
				addPanels[i].GirlData = girlDatas[i + girlRefOffset];
			}

			// 上記のループでガールが割り当てられなかったガール追加ボタンには、nullを渡す
			for( int i = 0; i < GIRL_NUM_BY_PAGE - loopNum; i++ )
			{
				addPanels[GIRL_NUM_BY_PAGE - i - 1].GirlData = null;
			}
		}



		/// <summary>
		/// センバツ設定中ガール一覧コンボボックス項目変更時イベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SelectedGirlListComboBox_SelectedIndexChaged( object sender, EventArgs e )
		{
			refreshSelectedGirlsList();
		}
    }
}
