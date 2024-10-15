// Decompiled with JetBrains decompiler
// Type: TargetCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200002B")]
[AddComponentMenu("Camera/TargetCamera")]
public class TargetCamera : MonoBehaviour
{
  [Token(Token = "0x40000C6")]
  [FieldOffset(Offset = "0xC")]
  private Vector3 mYawPitchRoll;
  [Token(Token = "0x40000C7")]
  [FieldOffset(Offset = "0x18")]
  private Vector3 mTargetPosition;
  [Token(Token = "0x40000C8")]
  [FieldOffset(Offset = "0x24")]
  private Transform mTransform;
  [Token(Token = "0x40000C9")]
  [FieldOffset(Offset = "0x28")]
  private float mCameraDistance;

  [Token(Token = "0x17000010")]
  public float CameraDistance
  {
    [Token(Token = "0x60000F3"), Address(RVA = "0x2CD720", Offset = "0x2CC520", VA = "0x102CD720")] set
    {
    }
    [Token(Token = "0x60000F4"), Address(RVA = "0x2CD6D0", Offset = "0x2CC4D0", VA = "0x102CD6D0")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x17000011")]
  public Vector3 TargetPosition
  {
    [Token(Token = "0x60000F5"), Address(RVA = "0x2CD6F0", Offset = "0x2CC4F0", VA = "0x102CD6F0")] get
    {
      return new Vector3();
    }
    [Token(Token = "0x60000F6"), Address(RVA = "0x2CD760", Offset = "0x2CC560", VA = "0x102CD760")] set
    {
    }
  }

  [Token(Token = "0x17000012")]
  public float Yaw
  {
    [Token(Token = "0x60000F7"), Address(RVA = "0x2CD710", Offset = "0x2CC510", VA = "0x102CD710")] get
    {
      return new float();
    }
    [Token(Token = "0x60000F8"), Address(RVA = "0x2CD790", Offset = "0x2CC590", VA = "0x102CD790")] set
    {
    }
  }

  [Token(Token = "0x17000013")]
  public float Pitch
  {
    [Token(Token = "0x60000F9"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
    {
      return new float();
    }
    [Token(Token = "0x60000FA"), Address(RVA = "0x2CD740", Offset = "0x2CC540", VA = "0x102CD740")] set
    {
    }
  }

  [Token(Token = "0x60000FB")]
  [Address(RVA = "0x2CD510", Offset = "0x2CC310", VA = "0x102CD510")]
  public void SetPositionYaw(Vector3 pos, float yaw)
  {
  }

  [Token(Token = "0x60000FC")]
  [Address(RVA = "0x2CD4D0", Offset = "0x2CC2D0", VA = "0x102CD4D0")]
  public void SetPositionYawPitch(Vector3 pos, float yaw, float pitch)
  {
  }

  [Token(Token = "0x60000FD")]
  [Address(RVA = "0x2CD160", Offset = "0x2CBF60", VA = "0x102CD160")]
  public void Reset()
  {
  }

  [Token(Token = "0x60000FE")]
  [Address(RVA = "0x2CCDC0", Offset = "0x2CBBC0", VA = "0x102CCDC0")]
  public static void CalcCameraPosition(
    out Vector3 position,
    out Quaternion rotation,
    Vector3 target,
    Vector3 rot,
    float distance)
  {
  }

  [Token(Token = "0x60000FF")]
  [Address(RVA = "0x2CCEB0", Offset = "0x2CBCB0", VA = "0x102CCEB0")]
  public static Quaternion CalcCameraRotation(Vector3 ypr) => new Quaternion();

  [Token(Token = "0x6000100")]
  [Address(RVA = "0x2CD540", Offset = "0x2CC340", VA = "0x102CD540")]
  private void UpdatePosition()
  {
  }

  [Token(Token = "0x6000101")]
  [Address(RVA = "0x2CCD90", Offset = "0x2CBB90", VA = "0x102CCD90")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000102")]
  [Address(RVA = "0x2CD100", Offset = "0x2CBF00", VA = "0x102CD100")]
  public static TargetCamera Get(GameObject go) => (TargetCamera) null;

  [Token(Token = "0x6000103")]
  [Address(RVA = "0x2CD090", Offset = "0x2CBE90", VA = "0x102CD090")]
  public static TargetCamera Get(Component go) => (TargetCamera) null;

  [Token(Token = "0x6000104")]
  [Address(RVA = "0x2CD690", Offset = "0x2CC490", VA = "0x102CD690")]
  public TargetCamera()
  {
  }
}
