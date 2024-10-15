// Decompiled with JetBrains decompiler
// Type: FastLoadRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x200008E")]
public class FastLoadRequest : LoadRequest
{
  [Token(Token = "0x40002C6")]
  [FieldOffset(Offset = "0x0")]
  private static double mLoadTime;
  [Token(Token = "0x40002C7")]
  private const double MaxLoadTimePerFrame = 0.0083333337679505348;
  [Token(Token = "0x40002C8")]
  [FieldOffset(Offset = "0x8")]
  private static List<FastLoadRequest> mRequests;
  [Token(Token = "0x40002C9")]
  [FieldOffset(Offset = "0x8")]
  private UnityEngine.Object mAsset;
  [Token(Token = "0x40002CA")]
  [FieldOffset(Offset = "0xC")]
  private bool mIsDone;
  [Token(Token = "0x40002CB")]
  [FieldOffset(Offset = "0x10")]
  private AssetBundleCache mAssetBundle;
  [Token(Token = "0x40002CC")]
  [FieldOffset(Offset = "0x14")]
  private AssetList.Item mAssetBundleNode;
  [Token(Token = "0x40002CD")]
  [FieldOffset(Offset = "0x18")]
  private string mAssetName;
  [Token(Token = "0x40002CE")]
  [FieldOffset(Offset = "0x1C")]
  private System.Type mAssetType;

  [Token(Token = "0x6000367")]
  [Address(RVA = "0xB8CD80", Offset = "0xB8BB80", VA = "0x10B8CD80")]
  public static void UpdateAll()
  {
  }

  [Token(Token = "0x6000368")]
  [Address(RVA = "0xB8D370", Offset = "0xB8C170", VA = "0x10B8D370")]
  public FastLoadRequest(AssetList.Item assetBundleNode, string assetName, System.Type assetType)
  {
  }

  [Token(Token = "0x6000369")]
  [Address(RVA = "0xB8CED0", Offset = "0xB8BCD0", VA = "0x10B8CED0")]
  private void UpdateLoading()
  {
  }

  [Token(Token = "0x1700008C")]
  public override float progress
  {
    [Token(Token = "0x600036A"), Address(RVA = "0xB8D420", Offset = "0xB8C220", VA = "0x10B8D420", Slot = "10")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x1700008D")]
  public override bool isDone
  {
    [Token(Token = "0x600036B"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80", Slot = "8")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700008E")]
  public override UnityEngine.Object asset
  {
    [Token(Token = "0x600036C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0", Slot = "7")] get
    {
      return (UnityEngine.Object) null;
    }
  }

  [Token(Token = "0x600036D")]
  [Address(RVA = "0x2E2F10", Offset = "0x2E1D10", VA = "0x102E2F10", Slot = "9")]
  public override bool MoveNext() => new bool();

  [Token(Token = "0x600036E")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "11")]
  public override void KeepSourceAlive()
  {
  }

  [Token(Token = "0x600036F")]
  [Address(RVA = "0xB8D2F0", Offset = "0xB8C0F0", VA = "0x10B8D2F0")]
  static FastLoadRequest()
  {
  }
}
