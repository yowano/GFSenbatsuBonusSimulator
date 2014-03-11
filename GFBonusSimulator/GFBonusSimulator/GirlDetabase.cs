using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GFBonusSimulator
{
	class GirlDetabase
	{
		/// <summary>
		/// SWEETタイプのガール一覧
		/// </summary>
		public static readonly Girl[] sweetGirls = new Girl[] {
			new Girl(
				"朝比奈桃子",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OEN, Bonus.eDef.MICROS, Bonus.eDef.NONE } ),
			new Girl(
				"浅見景",	
				new Bonus.eAtk[] { Bonus.eAtk.SEXY, Bonus.eAtk.COOL, Bonus.eAtk.SPORTY }, 
				new Bonus.eDef[] { Bonus.eDef.SEXY, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"天都かなた",	
				new Bonus.eAtk[] { Bonus.eAtk.SEXY, Bonus.eAtk.INKAI, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SEXY, Bonus.eDef.INKAI, Bonus.eDef.NONE } ),
			new Girl(
				"有栖川小枝子",	
				new Bonus.eAtk[] { Bonus.eAtk.BUCHO, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.BUCHO, Bonus.eDef.OEN, Bonus.eDef.NONE } ),
			new Girl(
				"伊勢崎郁歩",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.THE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"一色愛瑠",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NOT_NIKUSYOKU, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"円城寺子菊",	
				new Bonus.eAtk[] { Bonus.eAtk.MIRACLE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MICROS, Bonus.eDef.THE, Bonus.eDef.NONE } ),
			new Girl(
				"小倉愛",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"加賀美茉莉",	
				new Bonus.eAtk[] { Bonus.eAtk.LONELY, Bonus.eAtk.SPORTY, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.THE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"風町陽歌",	
				new Bonus.eAtk[] { Bonus.eAtk.MIRACLE, Bonus.eAtk.FUWAFUWA, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OEN, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"川上瀬莉",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.GOLD, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"クロエ・ルメール",	
				new Bonus.eAtk[] { Bonus.eAtk.SEAFOOD, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MANIAC, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"小日向いちご",	
				new Bonus.eAtk[] { Bonus.eAtk.FUWAFUWA, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MICROS, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"佐伯鞠香",	
				new Bonus.eAtk[] { Bonus.eAtk.INKAI, Bonus.eAtk.LIKE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.INKAI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"笹原野々花",	
				new Bonus.eAtk[] { Bonus.eAtk.GLAMOROUS, Bonus.eAtk.FUWAFUWA, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.THE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"島田泉",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.GOLD, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"白瀬つづり",	
				new Bonus.eAtk[] { Bonus.eAtk.REKISHI, Bonus.eAtk.LETS, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.CREATIVE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"白鳥詩織",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OEN, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"芹那",	
				new Bonus.eAtk[] { Bonus.eAtk.MIRACLE, Bonus.eAtk.FUWAFUWA, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"橘響子",	
				new Bonus.eAtk[] { Bonus.eAtk.SEIKATSU, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SEIKATSU, Bonus.eDef.MICROS, Bonus.eDef.NONE } ),
			new Girl(
				"鍋島ちより",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.GOLD, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"成瀬まなみ",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"新垣雛菜",	
				new Bonus.eAtk[] { Bonus.eAtk.SEAFOOD, Bonus.eAtk.COSMETIC, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.COSMETIC, Bonus.eDef.NONE } ),
			new Girl(
				"西野彩音",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OEN, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"新田萌果",	
				new Bonus.eAtk[] { Bonus.eAtk.MIRACLE, Bonus.eAtk.SEXY, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SEXY, Bonus.eDef.MICROS, Bonus.eDef.NONE } ),
			new Girl(
				"長谷川美卯",	
				new Bonus.eAtk[] { Bonus.eAtk.LIKE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NOT_NIKUSYOKU, Bonus.eDef.SLENDER, Bonus.eDef.NONE } ),
			new Girl(
				"林田たまき",	
				new Bonus.eAtk[] { Bonus.eAtk.MIRACLE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"柊真琴",	
				new Bonus.eAtk[] { Bonus.eAtk.FUWAFUWA, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.CREATIVE, Bonus.eDef.NONE } ),
			new Girl(
				"日野奏恵",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OEN, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"三科果歩",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.GOLD, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"三嶋ゆらら",	
				new Bonus.eAtk[] { Bonus.eAtk.BUCHO, Bonus.eAtk.MICHI, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.BUCHO, Bonus.eDef.MICHI, Bonus.eDef.NONE } ),
			new Girl(
				"南田七星",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"望月エレナ",	
				new Bonus.eAtk[] { Bonus.eAtk.SEXY, Bonus.eAtk.CENTER, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NOT_SWEETS, Bonus.eDef.SEXY, Bonus.eDef.NONE } ),
			new Girl(
				"森園芽以",	
				new Bonus.eAtk[] { Bonus.eAtk.LETS, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"山野こだま",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MICROS, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"優木苗",	
				new Bonus.eAtk[] { Bonus.eAtk.FUWAFUWA, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MICROS, Bonus.eDef.THE, Bonus.eDef.NONE } ),
			new Girl(
				"ゆの",	
				new Bonus.eAtk[] { Bonus.eAtk.FUWAFUWA, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.CREATIVE, Bonus.eDef.MICROS, Bonus.eDef.NONE } ),
			new Girl(
				"夢前春瑚",	
				new Bonus.eAtk[] { Bonus.eAtk.FUWAFUWA, Bonus.eAtk.LIKE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.CREATIVE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"ユーリヤ・ヴャルコワ",	
				new Bonus.eAtk[] { Bonus.eAtk.MIRACLE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"吉野屋先生",	
				new Bonus.eAtk[] { Bonus.eAtk.SEIKATSU, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SEIKATSU, Bonus.eDef.GOLD, Bonus.eDef.NONE } ),
		};


		/// <summary>
		/// COOLタイプガールのデータ一覧
		/// </summary>
		public static readonly Girl[] coolGirls = new Girl[] {
			new Girl(
				"赤瀬川摩姫",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"伊勢谷里都",	
				new Bonus.eAtk[] { Bonus.eAtk.LONELY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"岩本樹",	
				new Bonus.eAtk[] { Bonus.eAtk.REKISHI, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.CREATIVE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"音羽ユリ",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.OEN, Bonus.eDef.NONE } ),
	        new Girl(
				"皆藤蜜子",	
				new Bonus.eAtk[] { Bonus.eAtk.LETS, Bonus.eAtk.GLAMOROUS, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"神楽坂砂夜",	
				new Bonus.eAtk[] { Bonus.eAtk.REKISHI, Bonus.eAtk.BUCHO, Bonus.eAtk.SEXY }, 
				new Bonus.eDef[] { Bonus.eDef.BUCHO, Bonus.eDef.SEXY, Bonus.eDef.NONE } ),
	        new Girl(
				"上条るい",	
				new Bonus.eAtk[] { Bonus.eAtk.LETS, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SLENDER, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"川淵一美",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.LIKE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"神埼ミコト",	
				new Bonus.eAtk[] { Bonus.eAtk.SEIKATSU, Bonus.eAtk.GLAMOROUS, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SEIKATSU, Bonus.eDef.THE, Bonus.eDef.NONE } ),
	        new Girl(
				"君嶋里琉",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.GOLD, Bonus.eDef.SLENDER, Bonus.eDef.NONE } ),
	        new Girl(
				"霧生典子",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.COOL, Bonus.eAtk.INKAI }, 
				new Bonus.eDef[] { Bonus.eDef.INKAI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"黒川凪子",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OEN, Bonus.eDef.THE, Bonus.eDef.NONE } ),
	        new Girl(
				"五代律",	
				new Bonus.eAtk[] { Bonus.eAtk.REKISHI, Bonus.eAtk.COOL, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"椎名心実",	
				new Bonus.eAtk[] { Bonus.eAtk.MIRACLE, Bonus.eAtk.CENTER, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"鴫野睦",	
				new Bonus.eAtk[] { Bonus.eAtk.REKISHI, Bonus.eAtk.INKAI, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.INKAI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"重藤秋穂",	
				new Bonus.eAtk[] { Bonus.eAtk.BUCHO, Bonus.eAtk.LETS, Bonus.eAtk.LONELY }, 
				new Bonus.eDef[] { Bonus.eDef.BUCHO, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"東雲レイ",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SLENDER, Bonus.eDef.OKAERI, Bonus.eDef.NONE } ),
	        new Girl(
				"不知火五十鈴",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NOT_NIKUSYOKU, Bonus.eDef.MICROS, Bonus.eDef.NONE } ),
	        new Girl(
				"千代浦あやめ",	
				new Bonus.eAtk[] { Bonus.eAtk.LETS, Bonus.eAtk.LONELY, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.CREATIVE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"月白陽子",	
				new Bonus.eAtk[] { Bonus.eAtk.SEIKATSU, Bonus.eAtk.SEXY, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SEIKATSU, Bonus.eDef.SEXY, Bonus.eDef.NONE } ),
	        new Girl(
				"遠山未涼",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NOT_SWEETS, Bonus.eDef.SLENDER, Bonus.eDef.NONE } ),
	        new Girl(
				"夏目真尋",	
				new Bonus.eAtk[] { Bonus.eAtk.LONELY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.GOLD, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"南條クミコ",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MANIAC, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"飛原鋭子",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.BUCHO, Bonus.eAtk.LETS }, 
				new Bonus.eDef[] { Bonus.eDef.BUCHO, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"前田彩賀",	
				new Bonus.eAtk[] { Bonus.eAtk.REKISHI, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NOT_SWEETS, Bonus.eDef.MANIAC, Bonus.eDef.NONE } ),
	        new Girl(
				"正岡真衣",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"ミス・モノクローム",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.MICHI, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MICHI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"水野楓夏",	
				new Bonus.eAtk[] { Bonus.eAtk.SEIKATSU, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SEIKATSU, Bonus.eDef.THE, Bonus.eDef.NONE } ),
	        new Girl(
				"三吉奈央",	
				new Bonus.eAtk[] { Bonus.eAtk.COOL, Bonus.eAtk.COSMETIC, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.COSMETIC, Bonus.eDef.NONE } ),
	        new Girl(
				"村上文緒",	
				new Bonus.eAtk[] { Bonus.eAtk.SEXY, Bonus.eAtk.INKAI, Bonus.eAtk.LONELY }, 
				new Bonus.eDef[] { Bonus.eDef.SEXY, Bonus.eDef.INKAI, Bonus.eDef.NONE } ),
	        new Girl(
				"八束由紀恵",	
				new Bonus.eAtk[] { Bonus.eAtk.REKISHI, Bonus.eAtk.INKAI, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.INKAI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"雪風真弥",	
				new Bonus.eAtk[] { Bonus.eAtk.MIRACLE, Bonus.eAtk.COOL, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
	        new Girl(
				"龍ケ崎珠里椏",	
				new Bonus.eAtk[] { Bonus.eAtk.COOL, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } )
		};


		/// <summary>
		/// POPタイプのガール一覧
		/// </summary>
		public static readonly Girl[] popGirls = new Girl[] {
			new Girl(
				"甘利燈",	
				new Bonus.eAtk[] { Bonus.eAtk.SEAFOOD, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MANIAC, Bonus.eDef.THE, Bonus.eDef.NONE } ),
			new Girl(
				"綾小路美麗",	
				new Bonus.eAtk[] { Bonus.eAtk.SEAFOOD, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"石田いすき",	
				new Bonus.eAtk[] { Bonus.eAtk.REKISHI, Bonus.eAtk.MICHI, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MICROS, Bonus.eDef.MICHI, Bonus.eDef.NONE } ),
			new Girl(
				"江藤くるみ",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OEN, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"大山真由里",	
				new Bonus.eAtk[] { Bonus.eAtk.FIGHTER, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"緒川唯",	
				new Bonus.eAtk[] { Bonus.eAtk.MIRACLE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"押井知",	
				new Bonus.eAtk[] { Bonus.eAtk.MICHI, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SLENDER, Bonus.eDef.MICHI, Bonus.eDef.NONE } ),
			new Girl(
				"小野寺千鶴",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MANIAC, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"掛井園美",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"栢嶋乙女",	
				new Bonus.eAtk[] { Bonus.eAtk.LONELY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SLENDER, Bonus.eDef.MANIAC, Bonus.eDef.NONE } ),
			new Girl(
				"岸田稚慧",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"桐山優月",	
				new Bonus.eAtk[] { Bonus.eAtk.MICHI, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MANIAC, Bonus.eDef.MICHI, Bonus.eDef.NONE } ),
			new Girl(
				"熊田一葉",	
				new Bonus.eAtk[] { Bonus.eAtk.FIGHTER, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"小泉由佳",	
				new Bonus.eAtk[] { Bonus.eAtk.COSMETIC, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.COSMETIC, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"九重忍",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.BUCHO, Bonus.eAtk.SEXY }, 
				new Bonus.eDef[] { Bonus.eDef.BUCHO, Bonus.eDef.SEXY, Bonus.eDef.NONE } ),
			new Girl(
				"相楽エミ",	
				new Bonus.eAtk[] { Bonus.eAtk.SEXY, Bonus.eAtk.MIRACLE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SEXY, Bonus.eDef.THE, Bonus.eDef.NONE } ),
			new Girl(
				"櫻井明音",	
				new Bonus.eAtk[] { Bonus.eAtk.SEXY, Bonus.eAtk.CENTER, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SEXY, Bonus.eDef.THE, Bonus.eDef.NONE } ),
			new Girl(
				"鈴河凛乃",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.LIKE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"高崎瑠依",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"玉井麗巴",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"時谷小瑠璃",	
				new Bonus.eAtk[] { Bonus.eAtk.BUCHO, Bonus.eAtk.LETS, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.BUCHO, Bonus.eDef.MICROS, Bonus.eDef.NONE } ),
			new Girl(
				"戸村美知留",	
				new Bonus.eAtk[] { Bonus.eAtk.SEXY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SEXY, Bonus.eDef.OKAERI, Bonus.eDef.CREATIVE } ),
			new Girl(
				"なずな",	
				new Bonus.eAtk[] { Bonus.eAtk.FUWAFUWA, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"螺子川来夢",	
				new Bonus.eAtk[] { Bonus.eAtk.BUCHO, Bonus.eAtk.MICHI, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.BUCHO, Bonus.eDef.MICHI, Bonus.eDef.NONE } ),
			new Girl(
				"葉月柚子",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.THE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"羽鳥晶",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.THE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"林田希羅",	
				new Bonus.eAtk[] { Bonus.eAtk.MIRACLE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"早見英子",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SLENDER, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"春宮つぐみ",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NOT_SWEETS, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"東野梓",	
				new Bonus.eAtk[] { Bonus.eAtk.SPORTY, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"姫島木乃子",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.MICROS, Bonus.eDef.NONE } ),
			new Girl(
				"芙来田伊吹",	
				new Bonus.eAtk[] { Bonus.eAtk.LETS, Bonus.eAtk.MICHI, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MICHI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"古谷朱里",	
				new Bonus.eAtk[] { Bonus.eAtk.REKISHI, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MANIAC, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"皆口英里",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.SPORTY, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"宮内希",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.CREATIVE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"宮子",	
				new Bonus.eAtk[] { Bonus.eAtk.GLAMOROUS, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.CREATIVE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"山田はな",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"湯川基世",	
				new Bonus.eAtk[] { Bonus.eAtk.SANJUTSU, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.MICROS, Bonus.eDef.CREATIVE, Bonus.eDef.NONE } ),
			new Girl(
				"弓削楓",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.SLENDER, Bonus.eDef.OKAERI, Bonus.eDef.NONE } ),
			new Girl(
				"吉川繭子",	
				new Bonus.eAtk[] { Bonus.eAtk.SEXY, Bonus.eAtk.SPORTY, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.OKAERI, Bonus.eDef.SEXY, Bonus.eDef.NONE } ),
			new Girl(
				"李春燕",	
				new Bonus.eAtk[] { Bonus.eAtk.FIGHTER, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.NONE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
			new Girl(
				"乃莉",	
				new Bonus.eAtk[] { Bonus.eAtk.NONE, Bonus.eAtk.NONE, Bonus.eAtk.NONE }, 
				new Bonus.eDef[] { Bonus.eDef.CREATIVE, Bonus.eDef.NONE, Bonus.eDef.NONE } ),
		};
	}
}
