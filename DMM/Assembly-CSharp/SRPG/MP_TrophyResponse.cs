// Decompiled with JetBrains decompiler
// Type: SRPG.MP_TrophyResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D97")]
  [MessagePackObject(true)]
  public class MP_TrophyResponse : WebAPI.JSON_BaseResponse
  {
    [Token(Token = "0x4007533")]
    [FieldOffset(Offset = "0x28")]
    public JSON_TrophyResponse body;

    [Token(Token = "0x6007925")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public MP_TrophyResponse()
    {
    }
  }
}
