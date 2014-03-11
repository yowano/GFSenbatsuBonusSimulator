using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFBonusSimulator
{
    public class Bonus
    {
        /// <summary>
        /// 攻援センバツボーナスID
        /// </summary>
        public enum eAtk
        {
            SANJUTSU,
            REKISHI,
            SEIKATSU,
            BUCHO,
            SEAFOOD,
            SEXY,
            LETS,
            GLAMOROUS,
            MIRACLE,
            SPORTY,
            COOL,
            FUWAFUWA,
            FIGHTER,
            CENTER,
            INKAI,
            MICHI,
            COSMETIC,
            LIKE,
            LONELY,

            BONUS_NUM,

            NONE,
        }


        /// <summary>
        /// 守援センバツボーナスID
        /// </summary>
        public enum eDef
        {
            NOT_NIKUSYOKU,
            SLENDER,
            COSMETIC,
            BUCHO,
            NOT_SWEETS,
            INKAI,
            OEN,
            OKAERI,
            CREATIVE,
            THE,
            SEXY,
            MANIAC,
            MICROS,
            SEIKATSU,
            GOLD,
            MICHI,

            BONUS_NUM,

            NONE,
        }


        /// <summary>
        /// 攻援センバツボーナス名一覧
        /// </summary>
       public static readonly string[] atkName = new string[(int)eAtk.BONUS_NUM] {
            "算術スクレイパー",
            "歴史より愛をこめて",
            "生活指導",
            "★☆部長バースト☆★",
            "シーフードランデブー",
            "セクシーガールズ★キッス",
            "Let's 精神集中♪",
            "グラマラスソウル",
            "☆ミラクルパフォーマンス★",
            "スポーティーザッパー",
            "クールビューティーフラッシュ",
            "ふわふわらっぴんぐ",
            "ファイターチアーズ！",
            "センター★サポート",
            "委員会ペンタゴン",
            "未知への探究心",
            "☆コスメティックパワー☆",
            "ライク★アニマル★チアーズ",
            "ロンリーガールズレクイエム",
        };

        /// <summary>
        /// 守援センバツボーナス名一覧
        /// </summary>
        public static readonly string[] defName = new string[(int)eDef.BONUS_NUM] {
            "↑NOT肉食系女子パワー↑",
            "↑スレンダーズボルケーノ↑",
            "☆コスメティックパワー☆",
            "★☆部長バースト☆★",
            "♪NOTスイーツ女子パワー♪",
            "委員会ペンタゴン",
            "応援五重奏",
            "おかえりby帰宅部応援団",
            "クリエイティブ魂",
            "ザ・コレクターズパワー",
            "セクシーガールズ★キッス",
            "マニアックトルネード",
            "ミクロズ☆チアフル",
            "生活指導",
            "！ゴールドフィンガーズ！",
            "未知への探究心",       
        };
    }
}
