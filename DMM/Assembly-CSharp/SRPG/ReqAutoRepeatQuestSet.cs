// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAutoRepeatQuestSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003253")]
  public class ReqAutoRepeatQuestSet : WebAPI
  {
    [Token(Token = "0x600DEF4")]
    [Address(RVA = "0xA93850", Offset = "0xA92650", VA = "0x10A93850")]
    public ReqAutoRepeatQuestSet(
      ReqAutoRepeatQuestSet.Request request,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003254")]
    [Serializable]
    public class Request
    {
      [Token(Token = "0x400EE8D")]
      [FieldOffset(Offset = "0x8")]
      public int is_full_box;
      [Token(Token = "0x400EE8E")]
      [FieldOffset(Offset = "0xC")]
      public int is_use_drip;
      [Token(Token = "0x400EE8F")]
      [FieldOffset(Offset = "0x10")]
      public int is_push;

      [Token(Token = "0x600DEF5")]
      [Address(RVA = "0xA9FBD0", Offset = "0xA9E9D0", VA = "0x10A9FBD0")]
      public Request(bool full_box, bool drip, bool push)
      {
      }
    }
  }
}
