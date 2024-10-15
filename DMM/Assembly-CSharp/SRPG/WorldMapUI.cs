// Decompiled with JetBrains decompiler
// Type: SRPG.WorldMapUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D3B")]
  [AddComponentMenu("UI/WorldMapUI")]
  public class WorldMapUI : MonoBehaviour
  {
    [Token(Token = "0x400E181")]
    [FieldOffset(Offset = "0xC")]
    public UnityEngine.Camera TargetCamera;
    [Token(Token = "0x400E182")]
    [FieldOffset(Offset = "0x10")]
    private bool mDragging;
    [Token(Token = "0x400E183")]
    [FieldOffset(Offset = "0x14")]
    public float ScrollSpeed;

    [Token(Token = "0x600D2D1")]
    [Address(RVA = "0x9E17A0", Offset = "0x9E05A0", VA = "0x109E17A0")]
    private void Start()
    {
    }

    [Token(Token = "0x600D2D2")]
    [Address(RVA = "0x9E1670", Offset = "0x9E0470", VA = "0x109E1670")]
    private void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600D2D3")]
    [Address(RVA = "0x9E1790", Offset = "0x9E0590", VA = "0x109E1790")]
    private void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600D2D4")]
    [Address(RVA = "0x9E1680", Offset = "0x9E0480", VA = "0x109E1680")]
    private void OnDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600D2D5")]
    [Address(RVA = "0x9E18C0", Offset = "0x9E06C0", VA = "0x109E18C0")]
    public WorldMapUI()
    {
    }
  }
}
