// Decompiled with JetBrains decompiler
// Type: SRPG.AppealQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FD0")]
  public class AppealQuestMaster
  {
    [Token(Token = "0x40086EB")]
    [FieldOffset(Offset = "0x8")]
    public string appeal_id;
    [Token(Token = "0x40086EC")]
    [FieldOffset(Offset = "0x10")]
    public long start_at;
    [Token(Token = "0x40086ED")]
    [FieldOffset(Offset = "0x18")]
    public long end_at;

    [Token(Token = "0x600830C")]
    [Address(RVA = "0x438560", Offset = "0x437360", VA = "0x10438560")]
    public bool Deserialize(JSON_AppealQuestMaster json) => new bool();

    [Token(Token = "0x600830D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AppealQuestMaster()
    {
    }
  }
}
