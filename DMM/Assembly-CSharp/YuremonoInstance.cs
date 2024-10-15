// Decompiled with JetBrains decompiler
// Type: YuremonoInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001A0")]
[AddComponentMenu("Common/YuremonoInstance")]
public class YuremonoInstance : MonoBehaviour
{
  [Token(Token = "0x40007AF")]
  [FieldOffset(Offset = "0x0")]
  private static readonly Vector3[] mAxisToVector;
  [Token(Token = "0x40007B0")]
  [FieldOffset(Offset = "0xC")]
  public YuremonoParam Param;
  [Token(Token = "0x40007B1")]
  [FieldOffset(Offset = "0x10")]
  private List<YuremonoInstance.SkirtTraceStatus> mSkirtTraceStatusList;
  [Token(Token = "0x40007B2")]
  [FieldOffset(Offset = "0x14")]
  public Transform SpineTransform;
  [Token(Token = "0x40007B3")]
  [FieldOffset(Offset = "0x18")]
  private Quaternion mSpineBaseRotation;
  [Token(Token = "0x40007B4")]
  [FieldOffset(Offset = "0x28")]
  private Dictionary<string, Quaternion> mSkirtDiffHistory;
  [Token(Token = "0x40007B5")]
  [FieldOffset(Offset = "0x2C")]
  private List<YuremonoInstance.TargetState> mStates;
  [Token(Token = "0x40007B6")]
  [FieldOffset(Offset = "0x30")]
  public bool DisplayDebug;

  [Token(Token = "0x60009F3")]
  [Address(RVA = "0xF59990", Offset = "0xF58790", VA = "0x10F59990")]
  public void SkirtSetUp()
  {
  }

  [Token(Token = "0x60009F4")]
  [Address(RVA = "0xF57780", Offset = "0xF56580", VA = "0x10F57780")]
  private Quaternion GetSpineWorldRotation() => new Quaternion();

  [Token(Token = "0x60009F5")]
  [Address(RVA = "0xF58C30", Offset = "0xF57A30", VA = "0x10F58C30")]
  private void SkirtLateUpdate()
  {
  }

  [Token(Token = "0x60009F6")]
  [Address(RVA = "0xF5A070", Offset = "0xF58E70", VA = "0x10F5A070")]
  private void Start()
  {
  }

  [Token(Token = "0x60009F7")]
  [Address(RVA = "0xF586A0", Offset = "0xF574A0", VA = "0x10F586A0")]
  private void Reset()
  {
  }

  [Token(Token = "0x60009F8")]
  [Address(RVA = "0xF58750", Offset = "0xF57550", VA = "0x10F58750")]
  public void Setup()
  {
  }

  [Token(Token = "0x60009F9")]
  [Address(RVA = "0xF5A090", Offset = "0xF58E90", VA = "0x10F5A090")]
  private void Update()
  {
  }

  [Token(Token = "0x60009FA")]
  [Address(RVA = "0xF57610", Offset = "0xF56410", VA = "0x10F57610")]
  private static Vector3 CalcConstrainedPos(Vector3 pos, Vector3 origin, float distance)
  {
    return new Vector3();
  }

  [Token(Token = "0x60009FB")]
  [Address(RVA = "0xF579F0", Offset = "0xF567F0", VA = "0x10F579F0")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x60009FC")]
  [Address(RVA = "0xF5A310", Offset = "0xF59110", VA = "0x10F5A310")]
  public YuremonoInstance()
  {
  }

  [Token(Token = "0x60009FD")]
  [Address(RVA = "0xF5A180", Offset = "0xF58F80", VA = "0x10F5A180")]
  static YuremonoInstance()
  {
  }

  [Token(Token = "0x20001A1")]
  public class TargetState
  {
    [Token(Token = "0x40007B7")]
    [FieldOffset(Offset = "0x8")]
    public YuremonoParam.TargetParam Param;
    [Token(Token = "0x40007B8")]
    [FieldOffset(Offset = "0xC")]
    public Transform Transform;
    [Token(Token = "0x40007B9")]
    [FieldOffset(Offset = "0x10")]
    public Quaternion BaseRotation;
    [Token(Token = "0x40007BA")]
    [FieldOffset(Offset = "0x20")]
    public Vector3 TailPos;
    [Token(Token = "0x40007BB")]
    [FieldOffset(Offset = "0x2C")]
    public Vector3 DesiredTailPos;
    [Token(Token = "0x40007BC")]
    [FieldOffset(Offset = "0x38")]
    public Vector3 Forward;
    [Token(Token = "0x40007BD")]
    [FieldOffset(Offset = "0x44")]
    public Vector3 Velocity;

    [Token(Token = "0x1700014F")]
    public Vector3 Origin
    {
      [Token(Token = "0x60009FE"), Address(RVA = "0xF50730", Offset = "0xF4F530", VA = "0x10F50730")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17000150")]
    public Vector3 BaseTailPos
    {
      [Token(Token = "0x60009FF"), Address(RVA = "0xF50480", Offset = "0xF4F280", VA = "0x10F50480")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x6000A00")]
    [Address(RVA = "0xF50320", Offset = "0xF4F120", VA = "0x10F50320")]
    public Vector3 CalcScaledBaseTailPos(float scale) => new Vector3();

    [Token(Token = "0x17000151")]
    public Vector3 CurrentTailPos
    {
      [Token(Token = "0x6000A01"), Address(RVA = "0xF505D0", Offset = "0xF4F3D0", VA = "0x10F505D0")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17000152")]
    public bool IsValid
    {
      [Token(Token = "0x6000A02"), Address(RVA = "0xF506E0", Offset = "0xF4F4E0", VA = "0x10F506E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6000A03")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TargetState()
    {
    }
  }

  [Token(Token = "0x20001A2")]
  public class SkirtTraceStatus
  {
    [Token(Token = "0x40007BE")]
    [FieldOffset(Offset = "0x8")]
    public Transform Transform;
    [Token(Token = "0x40007BF")]
    [FieldOffset(Offset = "0xC")]
    public Vector3 BaseOffset;
    [Token(Token = "0x40007C0")]
    [FieldOffset(Offset = "0x18")]
    public Vector3 offsetTailPos;
    [Token(Token = "0x40007C1")]
    [FieldOffset(Offset = "0x24")]
    public Quaternion BaseRotaion;
    [Token(Token = "0x40007C2")]
    [FieldOffset(Offset = "0x34")]
    public float SkirtRatio;
    [Token(Token = "0x40007C3")]
    [FieldOffset(Offset = "0x38")]
    public float RotWait;
    [Token(Token = "0x40007C4")]
    [FieldOffset(Offset = "0x3C")]
    public float RotWaitAng;
    [Token(Token = "0x40007C5")]
    [FieldOffset(Offset = "0x40")]
    public Transform TargetTransform;
    [Token(Token = "0x40007C6")]
    [FieldOffset(Offset = "0x44")]
    public Transform TargetTailTransform;
    [Token(Token = "0x40007C7")]
    [FieldOffset(Offset = "0x48")]
    public Quaternion BaseTargetWorldRotationDiff;
    [Token(Token = "0x40007C8")]
    [FieldOffset(Offset = "0x58")]
    public YuremonoParam.SkirtTraceParam.EikyoSkirt[] EikyoSkirts;

    [Token(Token = "0x6000A04")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkirtTraceStatus()
    {
    }
  }
}
