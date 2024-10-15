// Decompiled with JetBrains decompiler
// Type: SRPG.DelayStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EAB")]
  [AddComponentMenu("Common/DelayStart")]
  public class DelayStart : MonoBehaviour
  {
    [Token(Token = "0x4002CFA")]
    [FieldOffset(Offset = "0xC")]
    public float ActivateInterval;
    [Token(Token = "0x4002CFB")]
    [FieldOffset(Offset = "0x10")]
    private List<GameObject> mChildren;
    [Token(Token = "0x4002CFC")]
    [FieldOffset(Offset = "0x14")]
    private int mActivateIndex;
    [Token(Token = "0x4002CFD")]
    [FieldOffset(Offset = "0x18")]
    private float mInterval;

    [Token(Token = "0x6003D05")]
    [Address(RVA = "0x10F52C0", Offset = "0x10F40C0", VA = "0x110F52C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003D06")]
    [Address(RVA = "0x10F53A0", Offset = "0x10F41A0", VA = "0x110F53A0")]
    private void Update()
    {
    }

    [Token(Token = "0x6003D07")]
    [Address(RVA = "0x10F54F0", Offset = "0x10F42F0", VA = "0x110F54F0")]
    public DelayStart()
    {
    }
  }
}
