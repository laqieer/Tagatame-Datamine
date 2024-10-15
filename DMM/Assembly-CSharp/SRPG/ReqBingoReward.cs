// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBingoReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030F6")]
  public class ReqBingoReward : ReqUpdateBingo
  {
    [Token(Token = "0x600DD88")]
    [Address(RVA = "0xA80970", Offset = "0xA7F770", VA = "0x10A80970")]
    public ReqBingoReward()
    {
    }

    [Token(Token = "0x600DD89")]
    [Address(RVA = "0xA80850", Offset = "0xA7F650", VA = "0x10A80850")]
    public ReqBingoReward(
      List<TrophyState> trophyprogs,
      SRPG.Network.ResponseCallback response,
      bool finish,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }
  }
}
