// Decompiled with JetBrains decompiler
// Type: SRPG.Json_LoginBonusTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200101E")]
  [MessagePackObject(true)]
  public class Json_LoginBonusTable
  {
    [Token(Token = "0x400395B")]
    [FieldOffset(Offset = "0x8")]
    public int count;
    [Token(Token = "0x400395C")]
    [FieldOffset(Offset = "0xC")]
    public string type;
    [Token(Token = "0x400395D")]
    [FieldOffset(Offset = "0x10")]
    public string prefab;
    [Token(Token = "0x400395E")]
    [FieldOffset(Offset = "0x14")]
    public string[] bonus_units;
    [Token(Token = "0x400395F")]
    [FieldOffset(Offset = "0x18")]
    public int lastday;
    [Token(Token = "0x4003960")]
    [FieldOffset(Offset = "0x1C")]
    public int[] login_days;
    [Token(Token = "0x4003961")]
    [FieldOffset(Offset = "0x20")]
    public int remain_recover;
    [Token(Token = "0x4003962")]
    [FieldOffset(Offset = "0x24")]
    public int max_recover;
    [Token(Token = "0x4003963")]
    [FieldOffset(Offset = "0x28")]
    public int current_month;
    [Token(Token = "0x4003964")]
    [FieldOffset(Offset = "0x2C")]
    public Json_LoginBonus[] bonuses;
    [Token(Token = "0x4003965")]
    [FieldOffset(Offset = "0x30")]
    public Json_PremiumLoginBonus[] premium_bonuses;

    [Token(Token = "0x17000610")]
    public bool IsCanRecover
    {
      [Token(Token = "0x6004282"), Address(RVA = "0x11DDB00", Offset = "0x11DC900", VA = "0x111DDB00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004283")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_LoginBonusTable()
    {
    }
  }
}
