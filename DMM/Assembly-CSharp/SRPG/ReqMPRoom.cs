// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMPRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030FF")]
  public class ReqMPRoom : WebAPI
  {
    [Token(Token = "0x600DD92")]
    [Address(RVA = "0xA87830", Offset = "0xA86630", VA = "0x10A87830")]
    public ReqMPRoom(string fuid, string iname, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003100")]
    public class Response
    {
      [Token(Token = "0x400EC68")]
      [FieldOffset(Offset = "0x8")]
      public MultiPlayAPIRoom[] rooms;

      [Token(Token = "0x600DD93")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
