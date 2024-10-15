// Decompiled with JetBrains decompiler
// Type: ResourceLoadRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200008C")]
public class ResourceLoadRequest : LoadRequest
{
  [Token(Token = "0x40002C0")]
  [FieldOffset(Offset = "0x8")]
  private Object mAsset;
  [Token(Token = "0x40002C1")]
  [FieldOffset(Offset = "0xC")]
  private ResourceRequest mLoadRequest;

  [Token(Token = "0x6000356")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public ResourceLoadRequest()
  {
  }

  [Token(Token = "0x6000357")]
  [Address(RVA = "0xB8DAF0", Offset = "0xB8C8F0", VA = "0x10B8DAF0")]
  public ResourceLoadRequest(ResourceRequest request)
  {
  }

  [Token(Token = "0x6000358")]
  [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
  public ResourceLoadRequest(Object _asset)
  {
  }

  [Token(Token = "0x17000086")]
  public override Object asset
  {
    [Token(Token = "0x6000359"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0", Slot = "7")] get
    {
      return (Object) null;
    }
  }

  [Token(Token = "0x17000087")]
  public override float progress
  {
    [Token(Token = "0x600035A"), Address(RVA = "0xB8DB90", Offset = "0xB8C990", VA = "0x10B8DB90", Slot = "10")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x17000088")]
  public override bool isDone
  {
    [Token(Token = "0x600035B"), Address(RVA = "0xB8DB20", Offset = "0xB8C920", VA = "0x10B8DB20", Slot = "8")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x600035C")]
  [Address(RVA = "0xB8DA20", Offset = "0xB8C820", VA = "0x10B8DA20", Slot = "9")]
  public override bool MoveNext() => new bool();

  [Token(Token = "0x600035D")]
  [Address(RVA = "0xB8DA90", Offset = "0xB8C890", VA = "0x10B8DA90")]
  private void UpdateLoading()
  {
  }
}
