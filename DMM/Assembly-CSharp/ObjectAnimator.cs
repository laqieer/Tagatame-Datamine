// Decompiled with JetBrains decompiler
// Type: ObjectAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000122")]
[AddComponentMenu("Common/ObjectAnimator")]
public class ObjectAnimator : MonoBehaviour
{
  [Token(Token = "0x400054B")]
  [FieldOffset(Offset = "0xC")]
  private ObjectAnimator.CurveType mCurveType;
  [Token(Token = "0x400054C")]
  [FieldOffset(Offset = "0x10")]
  private AnimationCurve mCurve;
  [Token(Token = "0x400054D")]
  [FieldOffset(Offset = "0x14")]
  private Vector3 mStartPos;
  [Token(Token = "0x400054E")]
  [FieldOffset(Offset = "0x20")]
  private Vector3 mEndPos;
  [Token(Token = "0x400054F")]
  [FieldOffset(Offset = "0x2C")]
  private Quaternion mStartRot;
  [Token(Token = "0x4000550")]
  [FieldOffset(Offset = "0x3C")]
  private Quaternion mEndRot;
  [Token(Token = "0x4000551")]
  [FieldOffset(Offset = "0x4C")]
  private Vector3 mStartScale;
  [Token(Token = "0x4000552")]
  [FieldOffset(Offset = "0x58")]
  private Vector3 mEndScale;
  [Token(Token = "0x4000553")]
  [FieldOffset(Offset = "0x64")]
  private float mTime;
  [Token(Token = "0x4000554")]
  [FieldOffset(Offset = "0x68")]
  private float mDuration;
  [Token(Token = "0x4000555")]
  [FieldOffset(Offset = "0x6C")]
  private bool mPositionSet;
  [Token(Token = "0x4000556")]
  [FieldOffset(Offset = "0x6D")]
  private bool mRotationSet;
  [Token(Token = "0x4000557")]
  [FieldOffset(Offset = "0x6E")]
  private bool mScaleSet;

  [Token(Token = "0x1700011B")]
  public bool isMoving
  {
    [Token(Token = "0x6000732"), Address(RVA = "0xD63580", Offset = "0xD62380", VA = "0x10D63580")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700011C")]
  public float NormalizedTime
  {
    [Token(Token = "0x6000733"), Address(RVA = "0xD63530", Offset = "0xD62330", VA = "0x10D63530")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x6000734")]
  [Address(RVA = "0xD63290", Offset = "0xD62090", VA = "0x10D63290")]
  private void Update()
  {
  }

  [Token(Token = "0x6000735")]
  [Address(RVA = "0xD631C0", Offset = "0xD61FC0", VA = "0x10D631C0")]
  public void ScaleTo(Vector3 scale, float duration, ObjectAnimator.CurveType curveType)
  {
  }

  [Token(Token = "0x6000736")]
  [Address(RVA = "0xD62E10", Offset = "0xD61C10", VA = "0x10D62E10")]
  public void AnimateTo(
    Vector3 position,
    Quaternion rotation,
    float duration,
    AnimationCurve curve)
  {
  }

  [Token(Token = "0x6000737")]
  [Address(RVA = "0xD62F50", Offset = "0xD61D50", VA = "0x10D62F50")]
  public void AnimateTo(
    Vector3 position,
    Quaternion rotation,
    float duration,
    ObjectAnimator.CurveType curveType)
  {
  }

  [Token(Token = "0x6000738")]
  [Address(RVA = "0xD63080", Offset = "0xD61E80", VA = "0x10D63080")]
  public static ObjectAnimator Get(Component component) => (ObjectAnimator) null;

  [Token(Token = "0x6000739")]
  [Address(RVA = "0xD63130", Offset = "0xD61F30", VA = "0x10D63130")]
  public static ObjectAnimator Get(GameObject obj) => (ObjectAnimator) null;

  [Token(Token = "0x600073A")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public ObjectAnimator()
  {
  }

  [Token(Token = "0x2000123")]
  public enum CurveType
  {
    [Token(Token = "0x4000559")] Linear,
    [Token(Token = "0x400055A")] EaseIn,
    [Token(Token = "0x400055B")] EaseOut,
    [Token(Token = "0x400055C")] EaseInOut,
  }
}
