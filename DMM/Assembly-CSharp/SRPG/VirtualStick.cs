// Decompiled with JetBrains decompiler
// Type: SRPG.VirtualStick
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D32")]
  [AddComponentMenu("UI/VirtualStick")]
  public class VirtualStick : MonoBehaviour
  {
    [Token(Token = "0x400E147")]
    [FieldOffset(Offset = "0x0")]
    public static VirtualStick Instance;
    [Token(Token = "0x400E148")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform VirtualStickBG;
    [Token(Token = "0x400E149")]
    [FieldOffset(Offset = "0x10")]
    public RectTransform VirtualStickFG;
    [Token(Token = "0x400E14A")]
    [FieldOffset(Offset = "0x14")]
    public RectTransform TouchArea;
    [Token(Token = "0x400E14B")]
    [FieldOffset(Offset = "0x18")]
    private bool mTouched;
    [Token(Token = "0x400E14C")]
    [FieldOffset(Offset = "0x1C")]
    private Vector3 mTouchStart;
    [Token(Token = "0x400E14D")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 mTouchPos;
    [Token(Token = "0x400E14E")]
    [FieldOffset(Offset = "0x34")]
    private Vector3 mVelocity;
    [Token(Token = "0x400E14F")]
    [FieldOffset(Offset = "0x40")]
    public string OpenFlagName;

    [Token(Token = "0x600D294")]
    [Address(RVA = "0x9DAF30", Offset = "0x9D9D30", VA = "0x109DAF30")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600D295")]
    [Address(RVA = "0x9DAEB0", Offset = "0x9D9CB0", VA = "0x109DAEB0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600D296")]
    [Address(RVA = "0x9DAD80", Offset = "0x9D9B80", VA = "0x109DAD80")]
    public Vector2 GetVelocity(Transform cameraTransform) => new Vector2();

    [Token(Token = "0x600D297")]
    [Address(RVA = "0x9DAFB0", Offset = "0x9D9DB0", VA = "0x109DAFB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600D298")]
    [Address(RVA = "0x9DB3B0", Offset = "0x9DA1B0", VA = "0x109DB3B0")]
    private void Update()
    {
    }

    [Token(Token = "0x600D299")]
    [Address(RVA = "0x9DB700", Offset = "0x9DA500", VA = "0x109DB700")]
    public VirtualStick()
    {
    }
  }
}
