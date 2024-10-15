// Decompiled with JetBrains decompiler
// Type: SRPG.ConditionsResult_HasItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EA8")]
  public class ConditionsResult_HasItem : ConditionsResult
  {
    [Token(Token = "0x170004D4")]
    public override string text
    {
      [Token(Token = "0x6003CFB"), Address(RVA = "0x10F3680", Offset = "0x10F2480", VA = "0x110F3680", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170004D5")]
    public override string errorText
    {
      [Token(Token = "0x6003CFC"), Address(RVA = "0x10F3630", Offset = "0x10F2430", VA = "0x110F3630", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003CFD")]
    [Address(RVA = "0x10F34D0", Offset = "0x10F22D0", VA = "0x110F34D0")]
    public ConditionsResult_HasItem(string iname, int condsItemNum)
    {
    }

    [Token(Token = "0x6003CFE")]
    [Address(RVA = "0x10F3550", Offset = "0x10F2350", VA = "0x110F3550")]
    public ConditionsResult_HasItem(string[] inames, int condsItemNum)
    {
    }
  }
}
