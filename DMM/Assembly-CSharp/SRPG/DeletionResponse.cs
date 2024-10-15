// Decompiled with JetBrains decompiler
// Type: SRPG.DeletionResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E3A")]
  [MessagePackObject(true)]
  [Serializable]
  public class DeletionResponse : WebAPI.JSON_BaseResponse
  {
    [Token(Token = "0x400E84D")]
    [FieldOffset(Offset = "0x28")]
    public DeletionResponseParam body;

    [Token(Token = "0x600DA7E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DeletionResponse()
    {
    }
  }
}
