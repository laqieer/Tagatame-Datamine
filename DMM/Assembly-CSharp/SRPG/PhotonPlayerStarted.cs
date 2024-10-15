// Decompiled with JetBrains decompiler
// Type: SRPG.PhotonPlayerStarted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001942")]
  [MessagePackObject(true)]
  public class PhotonPlayerStarted
  {
    [Token(Token = "0x4005B82")]
    [FieldOffset(Offset = "0x8")]
    public List<PhotonPlayerParameter> players;
    [Token(Token = "0x4005B83")]
    [FieldOffset(Offset = "0xC")]
    public string btlinfo;

    [Token(Token = "0x60066A2")]
    [Address(RVA = "0x32C160", Offset = "0x32AF60", VA = "0x1032C160")]
    public PhotonPlayerStarted()
    {
    }

    [Token(Token = "0x60066A3")]
    [Address(RVA = "0x32C1B0", Offset = "0x32AFB0", VA = "0x1032C1B0")]
    public PhotonPlayerStarted(List<PhotonPlayerParameter> players)
    {
    }
  }
}
