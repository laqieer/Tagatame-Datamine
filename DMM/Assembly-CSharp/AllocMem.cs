// Decompiled with JetBrains decompiler
// Type: AllocMem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200002F")]
[AddComponentMenu("Common/AllocMem")]
public class AllocMem : MonoBehaviour
{
  [Token(Token = "0x40000DA")]
  public const int SIZE_KB = 1024;
  [Token(Token = "0x40000DB")]
  public const int SIZE_MB = 1048576;
  [Token(Token = "0x40000DC")]
  [FieldOffset(Offset = "0xC")]
  public bool m_IsShow;
  [Token(Token = "0x40000DD")]
  [FieldOffset(Offset = "0xD")]
  public bool m_IsShowSubMemory;
  [Token(Token = "0x40000DE")]
  [FieldOffset(Offset = "0xE")]
  public bool m_IsShowGC;
  [Token(Token = "0x40000DF")]
  [FieldOffset(Offset = "0xF")]
  public bool m_IsShowEditor;
  [Token(Token = "0x40000E0")]
  [FieldOffset(Offset = "0x10")]
  public float m_FontSizeBase;
  [Token(Token = "0x40000E1")]
  [FieldOffset(Offset = "0x18")]
  private long m_UsedMemSize;
  [Token(Token = "0x40000E2")]
  [FieldOffset(Offset = "0x20")]
  private long m_MaxUsedMemSize;
  [Token(Token = "0x40000E3")]
  [FieldOffset(Offset = "0x28")]
  private float m_LastCollectTime;
  [Token(Token = "0x40000E4")]
  [FieldOffset(Offset = "0x2C")]
  private float m_LastCollectNum;
  [Token(Token = "0x40000E5")]
  [FieldOffset(Offset = "0x30")]
  private float m_CollectDeltaTime;
  [Token(Token = "0x40000E6")]
  [FieldOffset(Offset = "0x34")]
  private float m_LastCollectDeltaTime;
  [Token(Token = "0x40000E7")]
  [FieldOffset(Offset = "0x38")]
  private long m_AllocRate;
  [Token(Token = "0x40000E8")]
  [FieldOffset(Offset = "0x40")]
  private long m_LastAllocMemSize;
  [Token(Token = "0x40000E9")]
  [FieldOffset(Offset = "0x48")]
  private float m_LastAllocSet;

  [Token(Token = "0x600011B")]
  [Address(RVA = "0x2BB3E0", Offset = "0x2BA1E0", VA = "0x102BB3E0")]
  private void Start()
  {
  }

  [Token(Token = "0x600011C")]
  [Address(RVA = "0x2BB290", Offset = "0x2BA090", VA = "0x102BB290")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x600011D")]
  [Address(RVA = "0x2BBDC0", Offset = "0x2BABC0", VA = "0x102BBDC0")]
  private void profileStats()
  {
  }

  [Token(Token = "0x600011E")]
  [Address(RVA = "0x2BB430", Offset = "0x2BA230", VA = "0x102BB430")]
  private void drawStats()
  {
  }

  [Token(Token = "0x600011F")]
  [Address(RVA = "0x2BB400", Offset = "0x2BA200", VA = "0x102BB400")]
  public AllocMem()
  {
  }
}
