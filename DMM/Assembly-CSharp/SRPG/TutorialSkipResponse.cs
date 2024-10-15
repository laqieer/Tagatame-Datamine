// Decompiled with JetBrains decompiler
// Type: SRPG.TutorialSkipResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003037")]
  [MessagePackObject(true)]
  [Serializable]
  public class TutorialSkipResponse : WebAPI.JSON_BaseResponse
  {
    [Token(Token = "0x400EB99")]
    [FieldOffset(Offset = "0x28")]
    public ReqBookmarkBulkSkip.Response body;

    [Token(Token = "0x600DC9D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TutorialSkipResponse()
    {
    }
  }
}
