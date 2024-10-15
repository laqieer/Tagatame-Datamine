// Decompiled with JetBrains decompiler
// Type: SRPG.BGSlider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E73")]
  [AddComponentMenu("Common/BGSlider")]
  public class BGSlider : MonoBehaviour, IDragHandler, IEventSystemHandler
  {
    [Token(Token = "0x4002C29")]
    [FieldOffset(Offset = "0xC")]
    public float ScrollSpeed;
    [Token(Token = "0x4002C2A")]
    [FieldOffset(Offset = "0x10")]
    public float ReviseWidthValue;
    [Token(Token = "0x4002C2B")]
    [FieldOffset(Offset = "0x14")]
    public List<GiziScroll> SyncScrollWith;
    [Token(Token = "0x4002C2C")]
    [FieldOffset(Offset = "0x18")]
    public string SyncScrollWithID;
    [Token(Token = "0x4002C2D")]
    [FieldOffset(Offset = "0x1C")]
    private float mScrollPos;
    [Token(Token = "0x4002C2E")]
    [FieldOffset(Offset = "0x20")]
    private float mDesiredScrollPos;
    [Token(Token = "0x4002C2F")]
    [FieldOffset(Offset = "0x24")]
    private Vector2 mDefaultPosition;
    [Token(Token = "0x4002C30")]
    [FieldOffset(Offset = "0x2C")]
    private bool mResetScrollPos;
    [Token(Token = "0x4002C31")]
    [FieldOffset(Offset = "0x30")]
    public float DefaultScrollRatio;
    [Token(Token = "0x4002C32")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject[] PermissibleObjects;
    [Token(Token = "0x4002C33")]
    [FieldOffset(Offset = "0x38")]
    private float WHEEL_SCROLL_COEF;
    [Token(Token = "0x4002C34")]
    [FieldOffset(Offset = "0x3C")]
    private float axis_val;
    [Token(Token = "0x4002C35")]
    [FieldOffset(Offset = "0x40")]
    private List<RaycastResult> raycast_result_list;
    [Token(Token = "0x4002C36")]
    [FieldOffset(Offset = "0x44")]
    private List<GameObject> child_objects;
    [Token(Token = "0x4002C37")]
    [FieldOffset(Offset = "0x48")]
    private PointerEventData pointer_event;

    [Token(Token = "0x6003BDF")]
    [Address(RVA = "0x10E0F50", Offset = "0x10DFD50", VA = "0x110E0F50")]
    private void Start()
    {
    }

    [Token(Token = "0x6003BE0")]
    [Address(RVA = "0x10E0AB0", Offset = "0x10DF8B0", VA = "0x110E0AB0")]
    private void ClampScrollPos(float min, float max)
    {
    }

    [Token(Token = "0x6003BE1")]
    [Address(RVA = "0x10E1180", Offset = "0x10DFF80", VA = "0x110E1180")]
    private void Update()
    {
    }

    [Token(Token = "0x6003BE2")]
    [Address(RVA = "0x10E0DF0", Offset = "0x10DFBF0", VA = "0x110E0DF0", Slot = "4")]
    public void OnDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6003BE3")]
    [Address(RVA = "0x10E1100", Offset = "0x10DFF00", VA = "0x110E1100")]
    private void UpdateWheelScroll()
    {
    }

    [Token(Token = "0x6003BE4")]
    [Address(RVA = "0x10E0B00", Offset = "0x10DF900", VA = "0x110E0B00")]
    private bool IsHitRayCast() => new bool();

    [Token(Token = "0x6003BE5")]
    [Address(RVA = "0x10E1500", Offset = "0x10E0300", VA = "0x110E1500")]
    public BGSlider()
    {
    }
  }
}
