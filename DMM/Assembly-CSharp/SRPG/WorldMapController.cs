// Decompiled with JetBrains decompiler
// Type: SRPG.WorldMapController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001182")]
  [AddComponentMenu("Common/WorldMapController")]
  public class WorldMapController : MonoBehaviour
  {
    [Token(Token = "0x4003F75")]
    [FieldOffset(Offset = "0xC")]
    public AreaMapController[] AreaMaps;
    [Token(Token = "0x4003F76")]
    [FieldOffset(Offset = "0x10")]
    public RawImage[] Images;
    [Token(Token = "0x4003F77")]
    [FieldOffset(Offset = "0x14")]
    public RadialBlurEffect RadialBlurEffect;
    [Token(Token = "0x4003F78")]
    [FieldOffset(Offset = "0x18")]
    public bool AutoSelectArea;
    [Token(Token = "0x4003F79")]
    [FieldOffset(Offset = "0x1C")]
    private RectTransform mTransform;
    [Token(Token = "0x4003F7A")]
    [FieldOffset(Offset = "0x20")]
    private Vector2 mInitScale;
    [Token(Token = "0x4003F7B")]
    [FieldOffset(Offset = "0x28")]
    private Vector2 mInitPos;
    [Token(Token = "0x4003F7C")]
    [FieldOffset(Offset = "0x30")]
    private AreaMapController mCurrentArea;
    [Token(Token = "0x4003F7D")]
    [FieldOffset(Offset = "0x34")]
    private AreaMapController mPrevArea;
    [Token(Token = "0x4003F7E")]
    [FieldOffset(Offset = "0x38")]
    private AreaMapController mNextArea;
    [Token(Token = "0x4003F7F")]
    [FieldOffset(Offset = "0x3C")]
    public float TransitionTime;
    [Token(Token = "0x4003F80")]
    [FieldOffset(Offset = "0x40")]
    public AnimationCurve RadialBlurCurve;
    [Token(Token = "0x4003F81")]
    [FieldOffset(Offset = "0x44")]
    private StateMachine<WorldMapController> mStateMachine;
    [Token(Token = "0x4003F82")]
    [FieldOffset(Offset = "0x0")]
    private static WorldMapController mInstance;

    [Token(Token = "0x6004ACB")]
    [Address(RVA = "0x1214CF0", Offset = "0x1213AF0", VA = "0x11214CF0")]
    public static WorldMapController FindInstance(string gameobjectID) => (WorldMapController) null;

    [Token(Token = "0x17000839")]
    public static WorldMapController Instance
    {
      [Token(Token = "0x6004ACC"), Address(RVA = "0x1215420", Offset = "0x1214220", VA = "0x11215420")] get
      {
        return (WorldMapController) null;
      }
    }

    [Token(Token = "0x6004ACD")]
    [Address(RVA = "0x1214D90", Offset = "0x1213B90", VA = "0x11214D90")]
    public void GotoArea(string areaID)
    {
    }

    [Token(Token = "0x6004ACE")]
    [Address(RVA = "0x1214BD0", Offset = "0x12139D0", VA = "0x11214BD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6004ACF")]
    [Address(RVA = "0x1214E70", Offset = "0x1213C70", VA = "0x11214E70")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6004AD0")]
    [Address(RVA = "0x1215350", Offset = "0x1214150", VA = "0x11215350")]
    private void Start()
    {
    }

    [Token(Token = "0x6004AD1")]
    [Address(RVA = "0x1214E30", Offset = "0x1213C30", VA = "0x11214E30")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6004AD2")]
    [Address(RVA = "0x1215200", Offset = "0x1214000", VA = "0x11215200")]
    public void ResetAreaAll()
    {
    }

    [Token(Token = "0x6004AD3")]
    [Address(RVA = "0x12152C0", Offset = "0x12140C0", VA = "0x112152C0")]
    private void SetRadialBlurStrength(float t)
    {
    }

    [Token(Token = "0x6004AD4")]
    [Address(RVA = "0x1215360", Offset = "0x1214160", VA = "0x11215360")]
    private void Update()
    {
    }

    [Token(Token = "0x6004AD5")]
    [Address(RVA = "0x12153A0", Offset = "0x12141A0", VA = "0x112153A0")]
    public WorldMapController()
    {
    }

    [Token(Token = "0x2001183")]
    private class State_WorldSelect : State<WorldMapController>
    {
      [Token(Token = "0x6004AD6")]
      [Address(RVA = "0x1207170", Offset = "0x1205F70", VA = "0x11207170", Slot = "4")]
      public override void Begin(WorldMapController self)
      {
      }

      [Token(Token = "0x6004AD7")]
      [Address(RVA = "0x1207210", Offset = "0x1206010", VA = "0x11207210", Slot = "5")]
      public override void Update(WorldMapController self)
      {
      }

      [Token(Token = "0x6004AD8")]
      [Address(RVA = "0x1207290", Offset = "0x1206090", VA = "0x11207290")]
      public State_WorldSelect()
      {
      }
    }

    [Token(Token = "0x2001184")]
    private class State_World2Area : State<WorldMapController>
    {
      [Token(Token = "0x4003F83")]
      [FieldOffset(Offset = "0xC")]
      private float mTransition;
      [Token(Token = "0x4003F84")]
      [FieldOffset(Offset = "0x10")]
      private AreaMapController mTarget;
      [Token(Token = "0x4003F85")]
      [FieldOffset(Offset = "0x14")]
      private Vector2 mDesiredScale;
      [Token(Token = "0x4003F86")]
      [FieldOffset(Offset = "0x1C")]
      private Vector2 mDesiredPosition;
      [Token(Token = "0x4003F87")]
      [FieldOffset(Offset = "0x24")]
      private Vector2 mTargetPosition;

      [Token(Token = "0x6004AD9")]
      [Address(RVA = "0x1206B60", Offset = "0x1205960", VA = "0x11206B60", Slot = "4")]
      public override void Begin(WorldMapController self)
      {
      }

      [Token(Token = "0x6004ADA")]
      [Address(RVA = "0x1206DC0", Offset = "0x1205BC0", VA = "0x11206DC0", Slot = "5")]
      public override void Update(WorldMapController self)
      {
      }

      [Token(Token = "0x6004ADB")]
      [Address(RVA = "0x1207130", Offset = "0x1205F30", VA = "0x11207130")]
      public State_World2Area()
      {
      }
    }

    [Token(Token = "0x2001185")]
    private class State_AreaSelect : State<WorldMapController>
    {
      [Token(Token = "0x4003F88")]
      [FieldOffset(Offset = "0xC")]
      private AreaMapController mArea;

      [Token(Token = "0x6004ADC")]
      [Address(RVA = "0x1206A40", Offset = "0x1205840", VA = "0x11206A40", Slot = "4")]
      public override void Begin(WorldMapController self)
      {
      }

      [Token(Token = "0x6004ADD")]
      [Address(RVA = "0x1206A70", Offset = "0x1205870", VA = "0x11206A70", Slot = "5")]
      public override void Update(WorldMapController self)
      {
      }

      [Token(Token = "0x6004ADE")]
      [Address(RVA = "0x1206B20", Offset = "0x1205920", VA = "0x11206B20")]
      public State_AreaSelect()
      {
      }
    }

    [Token(Token = "0x2001186")]
    private class State_Area2World : State<WorldMapController>
    {
      [Token(Token = "0x4003F89")]
      [FieldOffset(Offset = "0xC")]
      private float mTransition;
      [Token(Token = "0x4003F8A")]
      [FieldOffset(Offset = "0x10")]
      private Vector2 mStartScale;
      [Token(Token = "0x4003F8B")]
      [FieldOffset(Offset = "0x18")]
      private Vector2 mStartPosition;

      [Token(Token = "0x6004ADF")]
      [Address(RVA = "0x1206640", Offset = "0x1205440", VA = "0x11206640", Slot = "4")]
      public override void Begin(WorldMapController self)
      {
      }

      [Token(Token = "0x6004AE0")]
      [Address(RVA = "0x1206760", Offset = "0x1205560", VA = "0x11206760", Slot = "5")]
      public override void Update(WorldMapController self)
      {
      }

      [Token(Token = "0x6004AE1")]
      [Address(RVA = "0x1206A00", Offset = "0x1205800", VA = "0x11206A00")]
      public State_Area2World()
      {
      }
    }
  }
}
