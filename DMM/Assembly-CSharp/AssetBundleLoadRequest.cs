// Decompiled with JetBrains decompiler
// Type: AssetBundleLoadRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200008D")]
public class AssetBundleLoadRequest : LoadRequest
{
  [Token(Token = "0x40002C2")]
  [FieldOffset(Offset = "0x8")]
  private UnityEngine.Object mAsset;
  [Token(Token = "0x40002C3")]
  [FieldOffset(Offset = "0xC")]
  private AssetBundleRequest mLoadRequest;
  [Token(Token = "0x40002C4")]
  [FieldOffset(Offset = "0x10")]
  private AssetBundleCache mAssetBundle;
  [Token(Token = "0x40002C5")]
  [FieldOffset(Offset = "0x14")]
  private System.Type mComponentClass;

  [Token(Token = "0x600035E")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public AssetBundleLoadRequest()
  {
  }

  [Token(Token = "0x600035F")]
  [Address(RVA = "0xB79DE0", Offset = "0xB78BE0", VA = "0x10B79DE0")]
  public AssetBundleLoadRequest(AssetBundleCache assetBundle, string assetName, System.Type assetType)
  {
  }

  [Token(Token = "0x6000360")]
  [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
  public AssetBundleLoadRequest(UnityEngine.Object _asset)
  {
  }

  [Token(Token = "0x17000089")]
  public override UnityEngine.Object asset
  {
    [Token(Token = "0x6000361"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0", Slot = "7")] get
    {
      return (UnityEngine.Object) null;
    }
  }

  [Token(Token = "0x1700008A")]
  public override float progress
  {
    [Token(Token = "0x6000362"), Address(RVA = "0xB79EE0", Offset = "0xB78CE0", VA = "0x10B79EE0", Slot = "10")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x1700008B")]
  public override bool isDone
  {
    [Token(Token = "0x6000363"), Address(RVA = "0xB79EC0", Offset = "0xB78CC0", VA = "0x10B79EC0", Slot = "8")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000364")]
  [Address(RVA = "0xB79980", Offset = "0xB78780", VA = "0x10B79980", Slot = "9")]
  public override bool MoveNext() => new bool();

  [Token(Token = "0x6000365")]
  [Address(RVA = "0xB799A0", Offset = "0xB787A0", VA = "0x10B799A0")]
  private void UpdateLoading()
  {
  }

  [Token(Token = "0x6000366")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "11")]
  public override void KeepSourceAlive()
  {
  }
}
