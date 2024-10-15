// Decompiled with JetBrains decompiler
// Type: SRPG.SyncColor
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
  [Token(Token = "0x2002B1C")]
  [RequireComponent(typeof (Graphic))]
  [AddComponentMenu("UI/SyncColor")]
  public class SyncColor : MonoBehaviour
  {
    [Token(Token = "0x400D26B")]
    [FieldOffset(Offset = "0xC")]
    private Graphic mGraphic;
    [Token(Token = "0x400D26C")]
    [FieldOffset(Offset = "0x10")]
    private Color mOriginColor;
    [Token(Token = "0x400D26D")]
    [FieldOffset(Offset = "0x20")]
    public CanvasRenderer Source;
    [Token(Token = "0x400D26E")]
    [FieldOffset(Offset = "0x24")]
    [BitMask]
    public SyncColor.ColorMasks ColorMask;
    [Token(Token = "0x400D26F")]
    [FieldOffset(Offset = "0x28")]
    public SyncColor.SyncType Type;

    [Token(Token = "0x600C54E")]
    [Address(RVA = "0x8DE560", Offset = "0x8DD360", VA = "0x108DE560")]
    private void Start()
    {
    }

    [Token(Token = "0x600C54F")]
    [Address(RVA = "0x8DE550", Offset = "0x8DD350", VA = "0x108DE550")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x600C550")]
    [Address(RVA = "0x8DE5E0", Offset = "0x8DD3E0", VA = "0x108DE5E0")]
    private void Sync()
    {
    }

    [Token(Token = "0x600C551")]
    [Address(RVA = "0x8DE540", Offset = "0x8DD340", VA = "0x108DE540")]
    public void ForceOriginColorChange(Color color)
    {
    }

    [Token(Token = "0x600C552")]
    [Address(RVA = "0x8DE780", Offset = "0x8DD580", VA = "0x108DE780")]
    public SyncColor()
    {
    }

    [Token(Token = "0x2002B1D")]
    public enum SyncType
    {
      [Token(Token = "0x400D271")] Override,
      [Token(Token = "0x400D272")] Multi,
    }

    [Token(Token = "0x2002B1E")]
    [Flags]
    public enum ColorMasks
    {
      [Token(Token = "0x400D274")] R = 1,
      [Token(Token = "0x400D275")] G = 2,
      [Token(Token = "0x400D276")] B = 4,
      [Token(Token = "0x400D277")] A = 8,
    }
  }
}
