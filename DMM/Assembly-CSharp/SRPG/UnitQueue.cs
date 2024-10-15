// Decompiled with JetBrains decompiler
// Type: SRPG.UnitQueue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CE9")]
  [AddComponentMenu("UI/UnitQueue")]
  public class UnitQueue : MonoBehaviour
  {
    [Token(Token = "0x400DF4B")]
    [FieldOffset(Offset = "0x0")]
    public static UnitQueue Instance;
    [Token(Token = "0x400DF4C")]
    [FieldOffset(Offset = "0xC")]
    public GameObject[] Items;
    [Token(Token = "0x400DF4D")]
    [FieldOffset(Offset = "0x10")]
    public UnitQueue.Layer[] Units;
    [Token(Token = "0x400DF4E")]
    [FieldOffset(Offset = "0x14")]
    public Button[] UnitButtons;
    [Token(Token = "0x400DF4F")]
    [FieldOffset(Offset = "0x18")]
    public GameObject LastUnit;
    [Token(Token = "0x400DF50")]
    [FieldOffset(Offset = "0x1C")]
    private Unit[] mCurrentUnits;

    [Token(Token = "0x600D107")]
    [Address(RVA = "0x9C01E0", Offset = "0x9BEFE0", VA = "0x109C01E0")]
    public void Refresh(Unit unit)
    {
    }

    [Token(Token = "0x600D108")]
    [Address(RVA = "0x9C0860", Offset = "0x9BF660", VA = "0x109C0860")]
    private void Start()
    {
    }

    [Token(Token = "0x600D109")]
    [Address(RVA = "0x9C03F0", Offset = "0x9BF1F0", VA = "0x109C03F0")]
    public void Refresh(int offset = 0)
    {
    }

    [Token(Token = "0x600D10A")]
    [Address(RVA = "0x9C0160", Offset = "0x9BEF60", VA = "0x109C0160")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600D10B")]
    [Address(RVA = "0x9C00E0", Offset = "0x9BEEE0", VA = "0x109C00E0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600D10C")]
    [Address(RVA = "0x9C08D0", Offset = "0x9BF6D0", VA = "0x109C08D0")]
    public UnitQueue()
    {
    }

    [Token(Token = "0x2002CEA")]
    [Serializable]
    public struct Layer
    {
      [Token(Token = "0x400DF51")]
      [FieldOffset(Offset = "0x0")]
      public GameObject[] Layers;
    }
  }
}
