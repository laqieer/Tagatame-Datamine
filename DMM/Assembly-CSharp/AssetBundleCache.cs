// Decompiled with JetBrains decompiler
// Type: AssetBundleCache
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200008A")]
public class AssetBundleCache
{
  [Token(Token = "0x40002BA")]
  [FieldOffset(Offset = "0x8")]
  public string Name;
  [Token(Token = "0x40002BB")]
  [FieldOffset(Offset = "0xC")]
  public int HashCode;
  [Token(Token = "0x40002BC")]
  [FieldOffset(Offset = "0x10")]
  public AssetBundle AssetBundle;
  [Token(Token = "0x40002BD")]
  [FieldOffset(Offset = "0x14")]
  public bool Persistent;
  [Token(Token = "0x40002BE")]
  [FieldOffset(Offset = "0x18")]
  public AssetBundleCache[] Dependencies;
  [Token(Token = "0x40002BF")]
  [FieldOffset(Offset = "0x1C")]
  public int NumReferencers;

  [Token(Token = "0x6000348")]
  [Address(RVA = "0xB79880", Offset = "0xB78680", VA = "0x10B79880")]
  public void AddReferencer(int count)
  {
  }

  [Token(Token = "0x6000349")]
  [Address(RVA = "0xB79890", Offset = "0xB78690", VA = "0x10B79890")]
  public void RemoveReferencer(int count)
  {
  }

  [Token(Token = "0x600034A")]
  [Address(RVA = "0xB79920", Offset = "0xB78720", VA = "0x10B79920")]
  public AssetBundleCache(string name, AssetBundle ab)
  {
  }

  [Token(Token = "0x600034B")]
  [Address(RVA = "0xB798A0", Offset = "0xB786A0", VA = "0x10B798A0")]
  public void Unload()
  {
  }
}
