// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUpdateTrophy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030EF")]
  public class ReqUpdateTrophy : WebAPI
  {
    [Token(Token = "0x400EC49")]
    [FieldOffset(Offset = "0x24")]
    private StringBuilder sb;
    [Token(Token = "0x400EC4A")]
    [FieldOffset(Offset = "0x28")]
    private bool is_begin;

    [Token(Token = "0x600DD76")]
    [Address(RVA = "0xA8D610", Offset = "0xA8C410", VA = "0x10A8D610")]
    public ReqUpdateTrophy()
    {
    }

    [Token(Token = "0x600DD77")]
    [Address(RVA = "0xA8D660", Offset = "0xA8C460", VA = "0x10A8D660")]
    public ReqUpdateTrophy(
      List<TrophyState> trophyprogs,
      SRPG.Network.ResponseCallback response,
      bool finish,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x600DD78")]
    [Address(RVA = "0xA8D160", Offset = "0xA8BF60", VA = "0x10A8D160")]
    public string GetTrophyReqString() => (string) null;

    [Token(Token = "0x600DD79")]
    [Address(RVA = "0xA8D590", Offset = "0xA8C390", VA = "0x10A8D590")]
    public void BeginTrophyReqString()
    {
    }

    [Token(Token = "0x600DD7A")]
    [Address(RVA = "0xA8D130", Offset = "0xA8BF30", VA = "0x10A8D130")]
    public void EndTrophyReqString()
    {
    }

    [Token(Token = "0x600DD7B")]
    [Address(RVA = "0xA8D270", Offset = "0xA8C070", VA = "0x10A8D270")]
    public void AddTrophyReqString(List<TrophyState> trophyprogs, bool finish)
    {
    }
  }
}
