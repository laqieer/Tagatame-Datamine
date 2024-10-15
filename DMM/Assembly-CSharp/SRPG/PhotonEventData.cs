// Decompiled with JetBrains decompiler
// Type: SRPG.PhotonEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200193B")]
  public class PhotonEventData
  {
    [Token(Token = "0x4005B40")]
    [FieldOffset(Offset = "0x8")]
    public PhotonManager.SendEventCode code;
    [Token(Token = "0x4005B41")]
    [FieldOffset(Offset = "0xC")]
    public int photonPlayerID;
    [Token(Token = "0x4005B42")]
    [FieldOffset(Offset = "0x10")]
    public string json;
    [Token(Token = "0x4005B43")]
    [FieldOffset(Offset = "0x14")]
    public byte[] binary;
    [Token(Token = "0x4005B44")]
    [FieldOffset(Offset = "0x18")]
    public int sequenceID;

    [Token(Token = "0x6006694")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PhotonEventData()
    {
    }
  }
}
