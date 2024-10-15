// Decompiled with JetBrains decompiler
// Type: ArenaDefenceUnits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200028D")]
[AddComponentMenu("UI/ArenaDefenceUnits")]
public class ArenaDefenceUnits : MonoBehaviour
{
  [Token(Token = "0x4000AB0")]
  [FieldOffset(Offset = "0x0")]
  public static List<UnitData> mArenaDefUnits;
  [Token(Token = "0x4000AB1")]
  [FieldOffset(Offset = "0x4")]
  private static bool mIsLoadEnd;
  [Token(Token = "0x4000AB2")]
  [FieldOffset(Offset = "0x5")]
  private static bool mIsLoading;
  [Token(Token = "0x4000AB3")]
  [FieldOffset(Offset = "0x8")]
  private static IEnumerator mLoadIEnumerator;

  [Token(Token = "0x6000D9B")]
  [Address(RVA = "0x11CBDC0", Offset = "0x11CABC0", VA = "0x111CBDC0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D9C")]
  [Address(RVA = "0x11CB9F0", Offset = "0x11CA7F0", VA = "0x111CB9F0")]
  public static void CompleteLoading()
  {
  }

  [Token(Token = "0x6000D9D")]
  [Address(RVA = "0x11CBB40", Offset = "0x11CA940", VA = "0x111CBB40")]
  private static void LoadArenaDefUnits()
  {
  }

  [Token(Token = "0x6000D9E")]
  [Address(RVA = "0x11CBD60", Offset = "0x11CAB60", VA = "0x111CBD60")]
  private IEnumerator LoadAsyncArenaDefUnits() => (IEnumerator) null;

  [Token(Token = "0x6000D9F")]
  [Address(RVA = "0x11CB8A0", Offset = "0x11CA6A0", VA = "0x111CB8A0")]
  private void Clear()
  {
  }

  [Token(Token = "0x6000DA0")]
  [Address(RVA = "0x11CBDB0", Offset = "0x11CABB0", VA = "0x111CBDB0")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000DA1")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public ArenaDefenceUnits()
  {
  }

  [Token(Token = "0x6000DA2")]
  [Address(RVA = "0x11CBE90", Offset = "0x11CAC90", VA = "0x111CBE90")]
  static ArenaDefenceUnits()
  {
  }
}
