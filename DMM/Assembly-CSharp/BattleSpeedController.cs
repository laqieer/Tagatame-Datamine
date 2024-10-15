// Decompiled with JetBrains decompiler
// Type: BattleSpeedController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000095")]
[AddComponentMenu("Common/BattleSpeedController")]
public class BattleSpeedController : MonoBehaviour
{
  [Token(Token = "0x40002DC")]
  public const float MIN_SPEED = 1f;
  [Token(Token = "0x40002DD")]
  public const float MAX_SPEED = 2f;
  [Token(Token = "0x40002DE")]
  [FieldOffset(Offset = "0x0")]
  public static readonly float[] SPEED_LIST;
  [Token(Token = "0x40002DF")]
  public const int DEFAULT_SPEED_NUM = 0;
  [Token(Token = "0x40002E0")]
  private const string IS_ENABLE_SPEED_CONTROLL = "IS_ENABLE_SPEED_CONTROLL";
  [Token(Token = "0x40002E1")]
  private const string BATTLE_SPEED_KEY = "BATTLE_SPEED_KEY";
  [Token(Token = "0x40002E2")]
  [FieldOffset(Offset = "0x4")]
  public static string REFLESH_KEY;
  [Token(Token = "0x40002E3")]
  [FieldOffset(Offset = "0x8")]
  private static GameUtility.BooleanConfig isEnableSpeedControll;
  [Token(Token = "0x40002E4")]
  [FieldOffset(Offset = "0xC")]
  private static float speed;
  [Token(Token = "0x40002E5")]
  [FieldOffset(Offset = "0x10")]
  private static bool isEnd;
  [Token(Token = "0x40002E6")]
  [FieldOffset(Offset = "0x14")]
  private static float[] enableSpeedlist;
  [Token(Token = "0x40002E7")]
  private const string VIP_SPEED_AUTO_ONLY = "VIP_SPEED_AUTO_ONLY";

  [Token(Token = "0x170000A3")]
  public static bool IsEnableSpeedControll
  {
    [Token(Token = "0x6000399"), Address(RVA = "0xB825A0", Offset = "0xB813A0", VA = "0x10B825A0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170000A4")]
  public static float PrefsSpeed
  {
    [Token(Token = "0x600039A"), Address(RVA = "0xB82600", Offset = "0xB81400", VA = "0x10B82600")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x170000A5")]
  public static float CurrentSpeed
  {
    [Token(Token = "0x600039B"), Address(RVA = "0xB824C0", Offset = "0xB812C0", VA = "0x10B824C0")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x170000A6")]
  public static float[] EnableSpeedList
  {
    [Token(Token = "0x600039C"), Address(RVA = "0xB82500", Offset = "0xB81300", VA = "0x10B82500")] get
    {
      return (float[]) null;
    }
  }

  [Token(Token = "0x170000A7")]
  public static bool isPremium
  {
    [Token(Token = "0x600039D"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170000A8")]
  public static bool isAutoOnly
  {
    [Token(Token = "0x600039E"), Address(RVA = "0xB82760", Offset = "0xB81560", VA = "0x10B82760")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170000A9")]
  public static bool BattleTimeConfig
  {
    [Token(Token = "0x600039F"), Address(RVA = "0xB82480", Offset = "0xB81280", VA = "0x10B82480")] get
    {
      return new bool();
    }
    [Token(Token = "0x60003A0"), Address(RVA = "0xB827D0", Offset = "0xB815D0", VA = "0x10B827D0")] set
    {
    }
  }

  [Token(Token = "0x60003A1")]
  [Address(RVA = "0xB81750", Offset = "0xB80550", VA = "0x10B81750")]
  public static void SetUp()
  {
  }

  [Token(Token = "0x60003A2")]
  [Address(RVA = "0xB809B0", Offset = "0xB7F7B0", VA = "0x10B809B0")]
  public static bool CheckEnableSpeedControll() => new bool();

  [Token(Token = "0x60003A3")]
  [Address(RVA = "0xB805F0", Offset = "0xB7F3F0", VA = "0x10B805F0")]
  public static void ChangeNextSpeed(bool isChangeBefore = false)
  {
  }

  [Token(Token = "0x60003A4")]
  [Address(RVA = "0xB80F10", Offset = "0xB7FD10", VA = "0x10B80F10")]
  public static int FindSpeedListNum(float inSpeed) => new int();

  [Token(Token = "0x60003A5")]
  [Address(RVA = "0xB811A0", Offset = "0xB7FFA0", VA = "0x10B811A0")]
  public static void OnContinue()
  {
  }

  [Token(Token = "0x60003A6")]
  [Address(RVA = "0xB81390", Offset = "0xB80190", VA = "0x10B81390")]
  public static void SetSpeed(float inSpeed)
  {
  }

  [Token(Token = "0x60003A7")]
  [Address(RVA = "0xB81660", Offset = "0xB80460", VA = "0x10B81660")]
  public static void SetStartSpeed(float inSpeed)
  {
  }

  [Token(Token = "0x60003A8")]
  [Address(RVA = "0xB81240", Offset = "0xB80040", VA = "0x10B81240")]
  public static void ResetSpeed()
  {
  }

  [Token(Token = "0x60003A9")]
  [Address(RVA = "0xB81700", Offset = "0xB80500", VA = "0x10B81700")]
  public static void SetTimeScale(float inSpeed)
  {
  }

  [Token(Token = "0x60003AA")]
  [Address(RVA = "0xB80E10", Offset = "0xB7FC10", VA = "0x10B80E10")]
  public static void EndBattle()
  {
  }

  [Token(Token = "0x60003AB")]
  [Address(RVA = "0xB80FC0", Offset = "0xB7FDC0", VA = "0x10B80FC0")]
  private static bool IsChangeSpeed() => new bool();

  [Token(Token = "0x60003AC")]
  [Address(RVA = "0xB810E0", Offset = "0xB7FEE0", VA = "0x10B810E0")]
  public static bool IsShowSpeedButton() => new bool();

  [Token(Token = "0x60003AD")]
  [Address(RVA = "0xB80900", Offset = "0xB7F700", VA = "0x10B80900")]
  public static bool CheckAllowedSpeedBattle(QuestParam quest) => new bool();

  [Token(Token = "0x60003AE")]
  [Address(RVA = "0xB822D0", Offset = "0xB810D0", VA = "0x10B822D0")]
  private static int WrapAroundSpeedNum(int num) => new int();

  [Token(Token = "0x60003AF")]
  [Address(RVA = "0xB81300", Offset = "0xB80100", VA = "0x10B81300")]
  public static float SaveLimitSpeed(float inSpeed) => new float();

  [Token(Token = "0x60003B0")]
  [Address(RVA = "0xB80B20", Offset = "0xB7F920", VA = "0x10B80B20")]
  public static float[] CreateBattleSpeedList() => (float[]) null;

  [Token(Token = "0x60003B1")]
  [Address(RVA = "0xB81C90", Offset = "0xB80A90", VA = "0x10B81C90")]
  public static void SetupEnableBattleSpeedList(ExpansionPurchaseData[] expansions = null)
  {
  }

  [Token(Token = "0x60003B2")]
  [Address(RVA = "0xB81F10", Offset = "0xB80D10", VA = "0x10B81F10")]
  public static void SetupEnableBattleSpeedList(string[] expansions)
  {
  }

  [Token(Token = "0x60003B3")]
  [Address(RVA = "0xB811E0", Offset = "0xB7FFE0", VA = "0x10B811E0")]
  public static void ResetEnableBattleSpeedList()
  {
  }

  [Token(Token = "0x60003B4")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public BattleSpeedController()
  {
  }

  [Token(Token = "0x60003B5")]
  [Address(RVA = "0xB82350", Offset = "0xB81150", VA = "0x10B82350")]
  static BattleSpeedController()
  {
  }
}
