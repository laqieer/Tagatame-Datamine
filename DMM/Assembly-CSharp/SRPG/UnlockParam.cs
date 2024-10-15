// Decompiled with JetBrains decompiler
// Type: SRPG.UnlockParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EAD")]
  public class UnlockParam
  {
    [Token(Token = "0x400807B")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400807C")]
    [FieldOffset(Offset = "0x10")]
    public UnlockTargets UnlockTarget;
    [Token(Token = "0x400807D")]
    [FieldOffset(Offset = "0x18")]
    public int PlayerLevel;
    [Token(Token = "0x400807E")]
    [FieldOffset(Offset = "0x1C")]
    public int VipRank;
    [Token(Token = "0x400807F")]
    [FieldOffset(Offset = "0x20")]
    public string[] ClearQuests;
    [Token(Token = "0x4008080")]
    [FieldOffset(Offset = "0x24")]
    public string OverWriteQuestText;

    [Token(Token = "0x6007DC3")]
    [Address(RVA = "0x3F7CB0", Offset = "0x3F6AB0", VA = "0x103F7CB0")]
    public bool Deserialize(JSON_UnlockParam json) => new bool();

    [Token(Token = "0x6007DC4")]
    [Address(RVA = "0x3F7E60", Offset = "0x3F6C60", VA = "0x103F7E60")]
    public bool IsExistConds_ClearQuest() => new bool();

    [Token(Token = "0x6007DC5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnlockParam()
    {
    }
  }
}
