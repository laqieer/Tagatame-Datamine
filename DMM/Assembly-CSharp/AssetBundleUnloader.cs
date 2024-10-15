// Decompiled with JetBrains decompiler
// Type: AssetBundleUnloader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000043")]
[AddComponentMenu("Common/AssetBundleUnloader")]
public class AssetBundleUnloader : MonoBehaviour
{
  [Token(Token = "0x4000149")]
  [FieldOffset(Offset = "0x0")]
  private static AssetBundleUnloader Inastance;
  [Token(Token = "0x400014A")]
  [FieldOffset(Offset = "0xC")]
  private List<AsyncOperation> mAsyncOperationList;
  [Token(Token = "0x400014B")]
  [FieldOffset(Offset = "0x10")]
  private bool mIsReservedUnload;
  [Token(Token = "0x400014C")]
  [FieldOffset(Offset = "0x11")]
  private bool mIsForceUnload;
  [Token(Token = "0x400014D")]
  [FieldOffset(Offset = "0x14")]
  private int mRestPassCount;
  [Token(Token = "0x400014E")]
  [FieldOffset(Offset = "0x18")]
  private readonly int PASS_COUNT;
  [Token(Token = "0x400014F")]
  [FieldOffset(Offset = "0x1C")]
  private bool mIsForceUnloadNow;

  [Token(Token = "0x17000028")]
  public static bool IsForceUnloadNow
  {
    [Token(Token = "0x6000190"), Address(RVA = "0x2D03A0", Offset = "0x2CF1A0", VA = "0x102D03A0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000191")]
  [Address(RVA = "0x2CFE80", Offset = "0x2CEC80", VA = "0x102CFE80")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000192")]
  [Address(RVA = "0x2D0070", Offset = "0x2CEE70", VA = "0x102D0070")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x6000193")]
  [Address(RVA = "0x2D02E0", Offset = "0x2CF0E0", VA = "0x102D02E0")]
  public static void ResetPassCount()
  {
  }

  [Token(Token = "0x6000194")]
  [Address(RVA = "0x2CFE20", Offset = "0x2CEC20", VA = "0x102CFE20")]
  public static void AddAsyncOperation(AsyncOperation ao)
  {
  }

  [Token(Token = "0x6000195")]
  [Address(RVA = "0x2D0280", Offset = "0x2CF080", VA = "0x102D0280")]
  public static void ReserveUnload(bool is_force)
  {
  }

  [Token(Token = "0x6000196")]
  [Address(RVA = "0x2D0220", Offset = "0x2CF020", VA = "0x102D0220")]
  public static void ReserveUnloadForce()
  {
  }

  [Token(Token = "0x6000197")]
  [Address(RVA = "0x2CFED0", Offset = "0x2CECD0", VA = "0x102CFED0")]
  private bool CanUnload() => new bool();

  [Token(Token = "0x6000198")]
  [Address(RVA = "0x2CFFB0", Offset = "0x2CEDB0", VA = "0x102CFFB0")]
  private void ExecUnload()
  {
  }

  [Token(Token = "0x6000199")]
  [Address(RVA = "0x2D0320", Offset = "0x2CF120", VA = "0x102D0320")]
  public AssetBundleUnloader()
  {
  }
}
