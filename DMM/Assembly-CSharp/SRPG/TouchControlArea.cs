// Decompiled with JetBrains decompiler
// Type: SRPG.TouchControlArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001173")]
  [AddComponentMenu("Common/TouchControlArea")]
  public class TouchControlArea : MonoBehaviour
  {
    [Token(Token = "0x4003F19")]
    private const float ROTATION_PER_WIDTH = 450f;
    [Token(Token = "0x4003F1A")]
    private const float NUM_OF_DIVISON_PER_WIDTH = 5f;
    [Token(Token = "0x4003F1B")]
    private const float CAMERA_POS_Z_MIN = 0.0f;
    [Token(Token = "0x4003F1C")]
    private const float CAMERA_POS_Z_MAX = 2.8f;
    [Token(Token = "0x4003F1D")]
    [FieldOffset(Offset = "0xC")]
    public string TargetObjID;
    [Token(Token = "0x4003F1E")]
    [FieldOffset(Offset = "0x10")]
    public string SillObjID;
    [Token(Token = "0x4003F1F")]
    [FieldOffset(Offset = "0x14")]
    public string CameraObjID;
    [Token(Token = "0x4003F20")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button ResetButton;
    [Token(Token = "0x4003F21")]
    [FieldOffset(Offset = "0x1C")]
    private GameObject m_CameraObj;
    [Token(Token = "0x4003F22")]
    [FieldOffset(Offset = "0x20")]
    private GameObject m_TargetObj;
    [Token(Token = "0x4003F23")]
    [FieldOffset(Offset = "0x24")]
    private UnityEngine.Camera m_Camera;
    [Token(Token = "0x4003F24")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 m_DefaultCameraPosition;
    [Token(Token = "0x4003F25")]
    [FieldOffset(Offset = "0x34")]
    private float m_DefaultAngle;
    [Token(Token = "0x4003F26")]
    [FieldOffset(Offset = "0x38")]
    private float m_Angle;
    [Token(Token = "0x4003F27")]
    [FieldOffset(Offset = "0x3C")]
    private float m_AngleBetween;
    [Token(Token = "0x4003F28")]
    [FieldOffset(Offset = "0x40")]
    private Vector3 m_PrevTouchPos;
    [Token(Token = "0x4003F29")]
    [FieldOffset(Offset = "0x4C")]
    private float m_MovedPosForAngle;
    [Token(Token = "0x4003F2A")]
    [FieldOffset(Offset = "0x50")]
    private float m_CameraOffsetZ;
    [Token(Token = "0x4003F2B")]
    [FieldOffset(Offset = "0x54")]
    private float m_CameraOffsetY;
    [Token(Token = "0x4003F2C")]
    [FieldOffset(Offset = "0x58")]
    private float m_PrevPinchDistance;
    [Token(Token = "0x4003F2D")]
    [FieldOffset(Offset = "0x5C")]
    private float m_CurrentPinchDistance;
    [Token(Token = "0x4003F2E")]
    [FieldOffset(Offset = "0x60")]
    private float m_PinchZoomRate;
    [Token(Token = "0x4003F2F")]
    [FieldOffset(Offset = "0x64")]
    private bool m_IsTouchDataChanged;

    [Token(Token = "0x6004A6C")]
    [Address(RVA = "0x120C0D0", Offset = "0x120AED0", VA = "0x1120C0D0")]
    private void Start()
    {
    }

    [Token(Token = "0x6004A6D")]
    [Address(RVA = "0x120B9E0", Offset = "0x120A7E0", VA = "0x1120B9E0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6004A6E")]
    [Address(RVA = "0x120BFD0", Offset = "0x120ADD0", VA = "0x1120BFD0")]
    public void Reset()
    {
    }

    [Token(Token = "0x6004A6F")]
    [Address(RVA = "0x120C880", Offset = "0x120B680", VA = "0x1120C880")]
    private void Update()
    {
    }

    [Token(Token = "0x6004A70")]
    [Address(RVA = "0x120C190", Offset = "0x120AF90", VA = "0x1120C190")]
    private void UpdateObjects()
    {
    }

    [Token(Token = "0x6004A71")]
    [Address(RVA = "0x120C410", Offset = "0x120B210", VA = "0x1120C410")]
    private void UpdateTouchDataForMobile()
    {
    }

    [Token(Token = "0x6004A72")]
    [Address(RVA = "0x120C700", Offset = "0x120B500", VA = "0x1120C700")]
    private void UpdateTouchDataForStandalone()
    {
    }

    [Token(Token = "0x6004A73")]
    [Address(RVA = "0x120C040", Offset = "0x120AE40", VA = "0x1120C040")]
    private void SetCameraPos(Vector3 position)
    {
    }

    [Token(Token = "0x6004A74")]
    [Address(RVA = "0x120B910", Offset = "0x120A710", VA = "0x1120B910")]
    private void BeginChangeCheck()
    {
    }

    [Token(Token = "0x6004A75")]
    [Address(RVA = "0x8D3C80", Offset = "0x8D2A80", VA = "0x108D3C80")]
    private bool EndChangeCheck() => new bool();

    [Token(Token = "0x6004A76")]
    [Address(RVA = "0x120B8E0", Offset = "0x120A6E0", VA = "0x1120B8E0")]
    private float Angle2MovedPos(float angle) => new float();

    [Token(Token = "0x6004A77")]
    [Address(RVA = "0x120BFA0", Offset = "0x120ADA0", VA = "0x1120BFA0")]
    private float MovedPos2Angle(float movedPos) => new float();

    [Token(Token = "0x6004A78")]
    [Address(RVA = "0x120B920", Offset = "0x120A720", VA = "0x1120B920")]
    private GameObject FindGameObject(string id) => (GameObject) null;

    [Token(Token = "0x6004A79")]
    [Address(RVA = "0x120CA20", Offset = "0x120B820", VA = "0x1120CA20")]
    public TouchControlArea()
    {
    }

    [Token(Token = "0x2001174")]
    public enum TouchState
    {
      [Token(Token = "0x4003F31")] None = -1, // 0xFFFFFFFF
      [Token(Token = "0x4003F32")] Began = 0,
      [Token(Token = "0x4003F33")] Moved = 1,
      [Token(Token = "0x4003F34")] Stationary = 2,
      [Token(Token = "0x4003F35")] Ended = 3,
      [Token(Token = "0x4003F36")] Canceled = 4,
    }
  }
}
