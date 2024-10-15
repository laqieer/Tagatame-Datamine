// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_OperateStandChara
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200129A")]
  [EventActionInfo("New/立ち絵2/編集(2D)", "立ち絵2を編集します。", 5592405, 4473992)]
  public class Event2dAction_OperateStandChara : EventAction
  {
    [Token(Token = "0x40044FF")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public string[] CharaIDs;
    [Token(Token = "0x4004500")]
    [FieldOffset(Offset = "0x1C")]
    private bool CharaIDsFoldout;
    [Token(Token = "0x4004501")]
    [FieldOffset(Offset = "0x20")]
    private List<EventStandCharaController2> mStandCharaList;
    [Token(Token = "0x4004502")]
    [FieldOffset(Offset = "0x24")]
    private List<RectTransform> mStandCharaTransformList;
    [Token(Token = "0x4004503")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> charaList;
    [Token(Token = "0x4004504")]
    [FieldOffset(Offset = "0x2C")]
    private List<Color> BodyColorList;
    [Token(Token = "0x4004505")]
    [FieldOffset(Offset = "0x30")]
    private List<Color> FaceColorList;
    [Token(Token = "0x4004506")]
    [FieldOffset(Offset = "0x34")]
    [HideInInspector]
    public bool async;
    [Token(Token = "0x4004507")]
    [FieldOffset(Offset = "0x35")]
    [HideInInspector]
    public bool Flip;
    [Token(Token = "0x4004508")]
    [FieldOffset(Offset = "0x36")]
    [HideInInspector]
    public bool MoveEnabled;
    [Token(Token = "0x4004509")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public float MoveTime;
    [Token(Token = "0x400450A")]
    [FieldOffset(Offset = "0x3C")]
    [HideInInspector]
    public AnimationCurve MoveCurve;
    [Token(Token = "0x400450B")]
    [FieldOffset(Offset = "0x40")]
    [HideInInspector]
    public Vector2 MoveTo;
    [Token(Token = "0x400450C")]
    [FieldOffset(Offset = "0x48")]
    [HideInInspector]
    public bool Relative;
    [Token(Token = "0x400450D")]
    [FieldOffset(Offset = "0x49")]
    private bool MoveFoldout;
    [Token(Token = "0x400450E")]
    [FieldOffset(Offset = "0x4C")]
    private float MoveOffset;
    [Token(Token = "0x400450F")]
    [FieldOffset(Offset = "0x50")]
    private List<Vector2> FromAnchorMinList;
    [Token(Token = "0x4004510")]
    [FieldOffset(Offset = "0x54")]
    private List<Vector2> FromAnchorMaxList;
    [Token(Token = "0x4004511")]
    [FieldOffset(Offset = "0x58")]
    private List<Vector2> mToAnchorList;
    [Token(Token = "0x4004512")]
    [FieldOffset(Offset = "0x5C")]
    [HideInInspector]
    public bool ScaleEnabled;
    [Token(Token = "0x4004513")]
    [FieldOffset(Offset = "0x60")]
    [HideInInspector]
    public float ScaleTime;
    [Token(Token = "0x4004514")]
    [FieldOffset(Offset = "0x64")]
    [HideInInspector]
    public AnimationCurve ScaleCurve;
    [Token(Token = "0x4004515")]
    [FieldOffset(Offset = "0x68")]
    [HideInInspector]
    public Vector2 ScaleTo;
    [Token(Token = "0x4004516")]
    [FieldOffset(Offset = "0x70")]
    private bool ScaleFoldout;
    [Token(Token = "0x4004517")]
    [FieldOffset(Offset = "0x74")]
    private float ScaleOffset;
    [Token(Token = "0x4004518")]
    [FieldOffset(Offset = "0x78")]
    private float mToWidth;
    [Token(Token = "0x4004519")]
    [FieldOffset(Offset = "0x7C")]
    private float mToHeght;
    [Token(Token = "0x400451A")]
    [FieldOffset(Offset = "0x80")]
    private List<float> FromWidthList;
    [Token(Token = "0x400451B")]
    [FieldOffset(Offset = "0x84")]
    private List<float> FromHeightList;
    [Token(Token = "0x400451C")]
    [FieldOffset(Offset = "0x88")]
    [HideInInspector]
    public bool ColorEnabled;
    [Token(Token = "0x400451D")]
    [FieldOffset(Offset = "0x8C")]
    [HideInInspector]
    public float ColorTime;
    [Token(Token = "0x400451E")]
    [FieldOffset(Offset = "0x90")]
    [HideInInspector]
    public AnimationCurve ColorCurve;
    [Token(Token = "0x400451F")]
    [FieldOffset(Offset = "0x94")]
    [HideInInspector]
    public Color ColorTo;
    [Token(Token = "0x4004520")]
    [FieldOffset(Offset = "0xA4")]
    private bool ColorFoldout;
    [Token(Token = "0x4004521")]
    [FieldOffset(Offset = "0xA8")]
    private float ColorOffset;
    [Token(Token = "0x4004522")]
    [FieldOffset(Offset = "0xAC")]
    private Color mToColor;
    [Token(Token = "0x4004523")]
    [FieldOffset(Offset = "0xBC")]
    private bool mMoveEnabled;
    [Token(Token = "0x4004524")]
    [FieldOffset(Offset = "0xBD")]
    private bool mScaleEnabled;
    [Token(Token = "0x4004525")]
    [FieldOffset(Offset = "0xBE")]
    private bool mColorEnabled;
    [Token(Token = "0x4004526")]
    [FieldOffset(Offset = "0x0")]
    public static Dictionary<string, Color> CharaColorDic;

    [Token(Token = "0x6004ECC")]
    [Address(RVA = "0x12407E0", Offset = "0x123F5E0", VA = "0x112407E0")]
    public static void DiscardAll()
    {
    }

    [Token(Token = "0x6004ECD")]
    [Address(RVA = "0x12412E0", Offset = "0x12400E0", VA = "0x112412E0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004ECE")]
    [Address(RVA = "0x1240840", Offset = "0x123F640", VA = "0x11240840", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004ECF")]
    [Address(RVA = "0x12413A0", Offset = "0x12401A0", VA = "0x112413A0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004ED0")]
    [Address(RVA = "0x1241FB0", Offset = "0x1240DB0", VA = "0x11241FB0")]
    private Vector2 convertPosition(Vector2 pos) => new Vector2();

    [Token(Token = "0x6004ED1")]
    [Address(RVA = "0x1241C40", Offset = "0x1240A40", VA = "0x11241C40")]
    public Event2dAction_OperateStandChara()
    {
    }

    [Token(Token = "0x6004ED2")]
    [Address(RVA = "0x1241BC0", Offset = "0x12409C0", VA = "0x11241BC0")]
    static Event2dAction_OperateStandChara()
    {
    }
  }
}
