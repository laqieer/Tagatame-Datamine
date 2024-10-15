// Decompiled with JetBrains decompiler
// Type: SRPG_Extensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200001B")]
public static class SRPG_Extensions
{
  [Token(Token = "0x400007A")]
  [FieldOffset(Offset = "0x0")]
  private static readonly string[] mPrefixes;

  [Token(Token = "0x6000087")]
  [Address(RVA = "0x2CB6D0", Offset = "0x2CA4D0", VA = "0x102CB6D0")]
  public static IntVector2 ToOffset(this EUnitDirection direction) => new IntVector2();

  [Token(Token = "0x6000088")]
  [Address(RVA = "0x2CBAB0", Offset = "0x2CA8B0", VA = "0x102CBAB0")]
  public static Vector3 ToVector(this EUnitDirection direction) => new Vector3();

  [Token(Token = "0x6000089")]
  [Address(RVA = "0x2CB900", Offset = "0x2CA700", VA = "0x102CB900")]
  public static Quaternion ToRotation(this EUnitDirection direction) => new Quaternion();

  [Token(Token = "0x600008A")]
  [Address(RVA = "0x2CA160", Offset = "0x2C8F60", VA = "0x102CA160")]
  public static bool Contains(this Rect rect, Rect other) => new bool();

  [Token(Token = "0x600008B")]
  [Address(RVA = "0x2CA350", Offset = "0x2C9150", VA = "0x102CA350")]
  public static UnitData GetInstanceData(
    this GameParameter.UnitInstanceTypes InstanceType,
    GameObject gameObject)
  {
    return (UnitData) null;
  }

  [Token(Token = "0x600008C")]
  [Address(RVA = "0x2CA920", Offset = "0x2C9720", VA = "0x102CA920")]
  public static void GetInstanceData(
    this GameParameter.ItemInstanceTypes instanceType,
    int index,
    GameObject gameObject,
    out ItemParam itemParam,
    out int itemNum)
  {
  }

  [Token(Token = "0x600008D")]
  [Address(RVA = "0x2CAFB0", Offset = "0x2C9DB0", VA = "0x102CAFB0")]
  public static string GetPath(this GameObject go, GameObject root = null) => (string) null;

  [Token(Token = "0x600008E")]
  public static T RequireComponent<T>(this Component component) where T : Component => (T) null;

  [Token(Token = "0x600008F")]
  public static T RequireComponent<T>(this GameObject go) where T : Component => (T) null;

  [Token(Token = "0x6000090")]
  [Address(RVA = "0x2CA020", Offset = "0x2C8E20", VA = "0x102CA020")]
  public static void AddClickListener(this Button button, ButtonExt.ButtonClickEvent listener)
  {
  }

  [Token(Token = "0x6000091")]
  [Address(RVA = "0x2CB190", Offset = "0x2C9F90", VA = "0x102CB190")]
  public static void RemoveClickListener(this Button button, ButtonExt.ButtonClickEvent listener)
  {
  }

  [Token(Token = "0x6000092")]
  [Address(RVA = "0x2CA0A0", Offset = "0x2C8EA0", VA = "0x102CA0A0")]
  public static string ComposeURL(this FlowNode_WebView.URL_Mode URLMode, string URL)
  {
    return (string) null;
  }

  [Token(Token = "0x6000093")]
  [Address(RVA = "0x2CA220", Offset = "0x2C9020", VA = "0x102CA220")]
  public static float Evaluate(this ObjectAnimator.CurveType curve, float t) => new float();

  [Token(Token = "0x6000094")]
  [Address(RVA = "0x2CB9C0", Offset = "0x2CA7C0", VA = "0x102CB9C0")]
  public static float ToSpan(this CameraInterpSpeed speed) => new float();

  [Token(Token = "0x6000095")]
  [Address(RVA = "0x2CB210", Offset = "0x2CA010", VA = "0x102CB210")]
  public static void SetNormalizedPosition(
    this ScrollRect scrollRect,
    Vector2 normalizedPos,
    bool blockRectSound)
  {
  }

  [Token(Token = "0x6000096")]
  [Address(RVA = "0x2CB9F0", Offset = "0x2CA7F0", VA = "0x102CB9F0")]
  public static UnlockTargets ToUnlockTargets(this EShopType type) => new UnlockTargets();

  [Token(Token = "0x6000097")]
  [Address(RVA = "0x2CB6A0", Offset = "0x2CA4A0", VA = "0x102CB6A0")]
  public static float ToFloat(this EventAction_Dialog.TextSpeedTypes speed) => new float();

  [Token(Token = "0x6000098")]
  [Address(RVA = "0x2CB6A0", Offset = "0x2CA4A0", VA = "0x102CB6A0")]
  public static float ToFloat(this Event2dAction_Dialog.TextSpeedTypes speed) => new float();

  [Token(Token = "0x6000099")]
  [Address(RVA = "0x2CB6A0", Offset = "0x2CA4A0", VA = "0x102CB6A0")]
  public static float ToFloat(this Event2dAction_Dialog2.TextSpeedTypes speed) => new float();

  [Token(Token = "0x600009A")]
  [Address(RVA = "0x2CB6A0", Offset = "0x2CA4A0", VA = "0x102CB6A0")]
  public static float ToFloat(this Event2dAction_Dialog3.TextSpeedTypes speed) => new float();

  [Token(Token = "0x600009B")]
  [Address(RVA = "0x2CB6A0", Offset = "0x2CA4A0", VA = "0x102CB6A0")]
  public static float ToFloat(this Event2dAction_Telop.TextSpeedTypes speed) => new float();

  [Token(Token = "0x600009C")]
  [Address(RVA = "0x2CBBB0", Offset = "0x2CA9B0", VA = "0x102CBBB0")]
  public static int ToYMD(this DateTime date) => new int();

  [Token(Token = "0x600009D")]
  [Address(RVA = "0x2CA2E0", Offset = "0x2C90E0", VA = "0x102CA2E0")]
  public static DateTime FromYMD(this int ymd) => new DateTime();

  [Token(Token = "0x600009E")]
  [Address(RVA = "0x2CB8A0", Offset = "0x2CA6A0", VA = "0x102CB8A0")]
  public static string ToPrefix(this ESex sex) => (string) null;

  [Token(Token = "0x600009F")]
  [Address(RVA = "0x2CB370", Offset = "0x2CA170", VA = "0x102CB370")]
  public static string ToColorValue(this Color32 src) => (string) null;

  [Token(Token = "0x60000A0")]
  [Address(RVA = "0x2CAD70", Offset = "0x2C9B70", VA = "0x102CAD70")]
  public static int GetMaxTeamCount(this PartyWindow2.EditPartyTypes type) => new int();

  [Token(Token = "0x60000A1")]
  [Address(RVA = "0x2CB740", Offset = "0x2CA540", VA = "0x102CB740")]
  public static PlayerPartyTypes ToPlayerPartyType(this PartyWindow2.EditPartyTypes type)
  {
    return new PlayerPartyTypes();
  }

  [Token(Token = "0x60000A2")]
  [Address(RVA = "0x2CB540", Offset = "0x2CA340", VA = "0x102CB540")]
  public static PartyWindow2.EditPartyTypes ToEditPartyType(this PlayerPartyTypes type)
  {
    return new PartyWindow2.EditPartyTypes();
  }

  [Token(Token = "0x60000A3")]
  [Address(RVA = "0x2CB2C0", Offset = "0x2CA0C0", VA = "0x102CB2C0")]
  public static void SetText(this InputField inputField, string value)
  {
  }

  [Token(Token = "0x60000A4")]
  [Address(RVA = "0x2CBC70", Offset = "0x2CAA70", VA = "0x102CBC70")]
  static SRPG_Extensions()
  {
  }
}
