// Decompiled with JetBrains decompiler
// Type: SRPG.ReqJukeBoxPlaylistAdd
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
  [Token(Token = "0x2003257")]
  public class ReqJukeBoxPlaylistAdd : WebAPI
  {
    [Token(Token = "0x600DEF8")]
    [Address(RVA = "0xA9AAF0", Offset = "0xA998F0", VA = "0x10A9AAF0")]
    public ReqJukeBoxPlaylistAdd(
      string[] bgm_list,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod type)
    {
    }

    [Token(Token = "0x2003258")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE92")]
      [FieldOffset(Offset = "0x8")]
      public string[] bgms;

      [Token(Token = "0x600DEF9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003259")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE93")]
      [FieldOffset(Offset = "0x8")]
      public JukeBoxWindow.ResPlayList[] playlists;

      [Token(Token = "0x600DEFA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
