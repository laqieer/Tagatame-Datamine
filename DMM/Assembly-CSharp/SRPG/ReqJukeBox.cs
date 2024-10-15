// Decompiled with JetBrains decompiler
// Type: SRPG.ReqJukeBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003255")]
  public class ReqJukeBox : WebAPI
  {
    [Token(Token = "0x600DEF6")]
    [Address(RVA = "0xA9ACB0", Offset = "0xA99AB0", VA = "0x10A9ACB0")]
    public ReqJukeBox(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod type)
    {
    }

    [Token(Token = "0x2003256")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE90")]
      [FieldOffset(Offset = "0x8")]
      public string[] bgms;
      [Token(Token = "0x400EE91")]
      [FieldOffset(Offset = "0xC")]
      public JukeBoxWindow.ResPlayList[] playlists;

      [Token(Token = "0x600DEF7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
