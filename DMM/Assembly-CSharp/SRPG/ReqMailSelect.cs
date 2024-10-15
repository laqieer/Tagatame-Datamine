// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMailSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031B6")]
  public class ReqMailSelect : WebAPI
  {
    [Token(Token = "0x600DE50")]
    [Address(RVA = "0xA9AF30", Offset = "0xA99D30", VA = "0x10A9AF30")]
    public ReqMailSelect(
      string ticketid,
      ReqMailSelect.type type,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031B7")]
    public enum type : byte
    {
      [Token(Token = "0x400ED76")] item,
      [Token(Token = "0x400ED77")] unit,
      [Token(Token = "0x400ED78")] artifact,
      [Token(Token = "0x400ED79")] conceptcard,
    }
  }
}
