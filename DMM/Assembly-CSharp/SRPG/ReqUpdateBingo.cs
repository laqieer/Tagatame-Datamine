// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUpdateBingo
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
  [Token(Token = "0x20030F5")]
  public class ReqUpdateBingo : WebAPI
  {
    [Token(Token = "0x400EC58")]
    [FieldOffset(Offset = "0x24")]
    private StringBuilder sb;
    [Token(Token = "0x400EC59")]
    [FieldOffset(Offset = "0x28")]
    private bool is_begin;

    [Token(Token = "0x600DD82")]
    [Address(RVA = "0xA80970", Offset = "0xA7F770", VA = "0x10A80970")]
    public ReqUpdateBingo()
    {
    }

    [Token(Token = "0x600DD83")]
    [Address(RVA = "0xA8D190", Offset = "0xA8BF90", VA = "0x10A8D190")]
    public ReqUpdateBingo(
      List<TrophyState> trophyprogs,
      SRPG.Network.ResponseCallback response,
      bool finish,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x600DD84")]
    [Address(RVA = "0xA8D160", Offset = "0xA8BF60", VA = "0x10A8D160")]
    public string GetBingoReqString() => (string) null;

    [Token(Token = "0x600DD85")]
    [Address(RVA = "0xA8D0B0", Offset = "0xA8BEB0", VA = "0x10A8D0B0")]
    public void BeginBingoReqString()
    {
    }

    [Token(Token = "0x600DD86")]
    [Address(RVA = "0xA8D130", Offset = "0xA8BF30", VA = "0x10A8D130")]
    public void EndBingoReqString()
    {
    }

    [Token(Token = "0x600DD87")]
    [Address(RVA = "0xA8CCF0", Offset = "0xA8BAF0", VA = "0x10A8CCF0")]
    public void AddBingoReqString(List<TrophyState> progs, bool finish)
    {
    }
  }
}
