// Decompiled with JetBrains decompiler
// Type: SRPG.DropGoldEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EAC")]
  [AddComponentMenu("Common/DropGoldEffect")]
  public class DropGoldEffect : MonoBehaviour
  {
    [Token(Token = "0x4002CFE")]
    public const string GOLD_GAMEOBJECT_NAME = "UI_GOLD";
    [Token(Token = "0x4002CFF")]
    [FieldOffset(Offset = "0xC")]
    [NonSerialized]
    public int Gold;
    [Token(Token = "0x4002D00")]
    [FieldOffset(Offset = "0x10")]
    private RectTransform m_TargetRect;
    [Token(Token = "0x4002D01")]
    [FieldOffset(Offset = "0x14")]
    private Unit m_DropOwner;

    [Token(Token = "0x170004DA")]
    public RectTransform TargetRect
    {
      [Token(Token = "0x6003D08"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170004DB")]
    public Unit DropOwner
    {
      [Token(Token = "0x6003D09"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
      [Token(Token = "0x6003D0A"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x6003D0B")]
    [Address(RVA = "0x10F5570", Offset = "0x10F4370", VA = "0x110F5570")]
    private void Start()
    {
    }

    [Token(Token = "0x6003D0C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DropGoldEffect()
    {
    }
  }
}
