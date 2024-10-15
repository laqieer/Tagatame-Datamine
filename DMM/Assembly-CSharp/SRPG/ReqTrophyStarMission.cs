// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTrophyStarMission
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
  [Token(Token = "0x200323A")]
  public class ReqTrophyStarMission : WebAPI
  {
    [Token(Token = "0x600DED8")]
    [Address(RVA = "0xA9F0C0", Offset = "0xA9DEC0", VA = "0x10A9F0C0")]
    public ReqTrophyStarMission(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200323B")]
    [MessagePackObject(true)]
    [Serializable]
    public class StarMission
    {
      [Token(Token = "0x400EE49")]
      [FieldOffset(Offset = "0x8")]
      public ReqTrophyStarMission.StarMission.Info daily;
      [Token(Token = "0x400EE4A")]
      [FieldOffset(Offset = "0xC")]
      public ReqTrophyStarMission.StarMission.Info weekly;

      [Token(Token = "0x600DED9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public StarMission()
      {
      }

      [Token(Token = "0x200323C")]
      [MessagePackObject(true)]
      [Serializable]
      public class Info
      {
        [Token(Token = "0x400EE4B")]
        [FieldOffset(Offset = "0x8")]
        public string iname;
        [Token(Token = "0x400EE4C")]
        [FieldOffset(Offset = "0xC")]
        public int ymd;
        [Token(Token = "0x400EE4D")]
        [FieldOffset(Offset = "0x10")]
        public int star_num;
        [Token(Token = "0x400EE4E")]
        [FieldOffset(Offset = "0x14")]
        public int[] rewards;

        [Token(Token = "0x600DEDA")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Info()
        {
        }
      }
    }

    [Token(Token = "0x200323D")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE4F")]
      [FieldOffset(Offset = "0x8")]
      public ReqTrophyStarMission.StarMission star_mission;

      [Token(Token = "0x600DEDB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
