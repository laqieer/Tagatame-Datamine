// Decompiled with JetBrains decompiler
// Type: SRPG.AudienceStartParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E25")]
  [Serializable]
  public class AudienceStartParam
  {
    [Token(Token = "0x4002ADC")]
    [FieldOffset(Offset = "0x8")]
    public PhotonPlayerParameter[] players;
    [Token(Token = "0x4002ADD")]
    [FieldOffset(Offset = "0xC")]
    public BattleCore.Json_BtlInfo btlinfo;

    [Token(Token = "0x6003A3E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AudienceStartParam()
    {
    }
  }
}
