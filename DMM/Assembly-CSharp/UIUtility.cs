// Decompiled with JetBrains decompiler
// Type: UIUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002EF")]
public class UIUtility
{
  [Token(Token = "0x4000C31")]
  [FieldOffset(Offset = "0x0")]
  private static Canvas mParticleCanvas;
  [Token(Token = "0x4000C32")]
  [FieldOffset(Offset = "0x4")]
  private static RectTransform mUIPool;
  [Token(Token = "0x4000C33")]
  [FieldOffset(Offset = "0x8")]
  private static Canvas mCanvas2D;
  [Token(Token = "0x4000C34")]
  public const float DEFAULT_ANIM_COMPLETE_TIME = 0.3f;

  [Token(Token = "0x6000F33")]
  [Address(RVA = "0x12A8990", Offset = "0x12A7790", VA = "0x112A8990")]
  public static void InitParticleCanvas()
  {
  }

  [Token(Token = "0x170001D0")]
  public static Canvas ParticleCanvas
  {
    [Token(Token = "0x6000F34"), Address(RVA = "0x12AA1A0", Offset = "0x12A8FA0", VA = "0x112AA1A0")] get
    {
      return (Canvas) null;
    }
  }

  [Token(Token = "0x6000F35")]
  [Address(RVA = "0x12A9170", Offset = "0x12A7F70", VA = "0x112A9170")]
  public static Canvas PushCanvas(bool systemModal = false, int systemModalPriority = -1)
  {
    return (Canvas) null;
  }

  [Token(Token = "0x6000F36")]
  [Address(RVA = "0x12A9050", Offset = "0x12A7E50", VA = "0x112A9050")]
  public static void PopCanvas()
  {
  }

  [Token(Token = "0x6000F37")]
  [Address(RVA = "0x12A9060", Offset = "0x12A7E60", VA = "0x112A9060")]
  public static void PopCanvas(bool keepInstance)
  {
  }

  [Token(Token = "0x6000F38")]
  [Address(RVA = "0x12A8FC0", Offset = "0x12A7DC0", VA = "0x112A8FC0")]
  public static void PopCanvasAll()
  {
  }

  [Token(Token = "0x6000F39")]
  [Address(RVA = "0x12A92B0", Offset = "0x12A80B0", VA = "0x112A92B0")]
  public static void ResetInput()
  {
  }

  [Token(Token = "0x6000F3A")]
  [Address(RVA = "0x12A7920", Offset = "0x12A6720", VA = "0x112A7920")]
  public static GameObject CoinConfirmBox(
    string title,
    string main,
    string sub,
    UIUtility.DialogResultEvent okEventListener,
    UIUtility.DialogResultEvent cancelEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1,
    string yesText = null,
    string noText = null,
    bool isDisplayCoin = true,
    string periodText = null)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F3B")]
  [Address(RVA = "0x12A8760", Offset = "0x12A7560", VA = "0x112A8760")]
  public static GameObject ConfirmBox(
    string text,
    string confirmID,
    UIUtility.DialogResultEvent okEventListener,
    UIUtility.DialogResultEvent cancelEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1,
    TextAnchor anchor = TextAnchor.UpperCenter)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F3C")]
  [Address(RVA = "0x12A8590", Offset = "0x12A7390", VA = "0x112A8590")]
  public static GameObject ConfirmBox(
    string text,
    UIUtility.DialogResultEvent okEventListener,
    UIUtility.DialogResultEvent cancelEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1,
    string yesText = null,
    string noText = null,
    TextAnchor anchor = TextAnchor.UpperCenter)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F3D")]
  [Address(RVA = "0x12A83A0", Offset = "0x12A71A0", VA = "0x112A83A0")]
  public static GameObject ConfirmBoxTitle(
    string title,
    string text,
    UIUtility.DialogResultEvent okEventListener,
    UIUtility.DialogResultEvent cancelEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1,
    string yesText = null,
    string noText = null,
    TextAnchor anchor = TextAnchor.UpperCenter)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F3E")]
  [Address(RVA = "0x12A7AF0", Offset = "0x12A68F0", VA = "0x112A7AF0")]
  public static GameObject ConfirmBoxTitleWithDelay(
    string title,
    string text,
    UIUtility.DialogResultEvent okEventListener,
    UIUtility.DialogResultEvent cancelEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1,
    string yesText = null,
    string noText = null,
    float yesDelay = 0.0f,
    float noDelay = 0.0f,
    TextAnchor anchor = TextAnchor.UpperCenter)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F3F")]
  [Address(RVA = "0x12A81A0", Offset = "0x12A6FA0", VA = "0x112A81A0")]
  public static GameObject ConfirmBoxTitleWithScroll(
    string title,
    string text,
    UIUtility.DialogResultEvent okEventListener,
    UIUtility.DialogResultEvent cancelEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1,
    string yesText = null,
    string noText = null,
    TextAnchor anchor = TextAnchor.UpperCenter)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F40")]
  [Address(RVA = "0x12A7FA0", Offset = "0x12A6DA0", VA = "0x112A7FA0")]
  public static GameObject ConfirmBoxTitleWithScrollReverse(
    string title,
    string text,
    UIUtility.DialogResultEvent okEventListener,
    UIUtility.DialogResultEvent cancelEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1,
    string yesText = null,
    string noText = null,
    TextAnchor anchor = TextAnchor.UpperCenter)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F41")]
  [Address(RVA = "0x12A7D70", Offset = "0x12A6B70", VA = "0x112A7D70")]
  public static GameObject ConfirmBoxTitleWithScrollCheck(
    string title,
    string text,
    UIUtility.DialogResultEvent okEventListener,
    UIUtility.DialogResultEvent cancelEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1,
    string yesText = null,
    string noText = null,
    string checkText = null,
    TextAnchor anchor = TextAnchor.UpperCenter)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F42")]
  [Address(RVA = "0x12A9E00", Offset = "0x12A8C00", VA = "0x112A9E00")]
  public static GameObject SystemMessage(
    string title,
    string msg,
    UIUtility.DialogResultEvent okEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1,
    TextAnchor anchor = TextAnchor.UpperCenter)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F43")]
  [Address(RVA = "0x12A9CA0", Offset = "0x12A8AA0", VA = "0x112A9CA0")]
  public static GameObject SystemMessage(
    string msg,
    UIUtility.DialogResultEvent okEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1,
    TextAnchor anchor = TextAnchor.UpperCenter)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F44")]
  [Address(RVA = "0x12A8EE0", Offset = "0x12A7CE0", VA = "0x112A8EE0")]
  public static GameObject NegativeSystemMessage(
    string title,
    string msg,
    UIUtility.DialogResultEvent okEventListener,
    GameObject parent = null,
    bool systemModal = false,
    int systemModalPriority = -1)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000F45")]
  [Address(RVA = "0x12A9500", Offset = "0x12A8300", VA = "0x112A9500")]
  public static void SetImage(GameObject obj, Texture tex)
  {
  }

  [Token(Token = "0x6000F46")]
  [Address(RVA = "0x12A93F0", Offset = "0x12A81F0", VA = "0x112A93F0")]
  public static void SetImage(Component obj, Texture tex)
  {
  }

  [Token(Token = "0x6000F47")]
  [Address(RVA = "0x12A96C0", Offset = "0x12A84C0", VA = "0x112A96C0")]
  public static void SetSprite(GameObject obj, Sprite tex)
  {
  }

  [Token(Token = "0x6000F48")]
  [Address(RVA = "0x12A95B0", Offset = "0x12A83B0", VA = "0x112A95B0")]
  public static void SetSprite(Component obj, Sprite tex)
  {
  }

  [Token(Token = "0x6000F49")]
  public static T Instantiate<T>(T prefab) where T : Component => (T) null;

  [Token(Token = "0x6000F4A")]
  [Address(RVA = "0x12A8C80", Offset = "0x12A7A80", VA = "0x112A8C80")]
  public static GameObject Instantiate(GameObject prefab) => (GameObject) null;

  [Token(Token = "0x6000F4B")]
  [Address(RVA = "0x12A8C10", Offset = "0x12A7A10", VA = "0x112A8C10")]
  public static GameObject Instantiate(ResourceRequest req) => (GameObject) null;

  [Token(Token = "0x6000F4C")]
  public static T Instantiate<T>(Component prefab) where T : Component => (T) null;

  [Token(Token = "0x6000F4D")]
  public static T Instantiate<T>(GameObject prefab) where T : Component => (T) null;

  [Token(Token = "0x6000F4E")]
  public static T Instantiate<T>(ResourceRequest req) where T : Component => (T) null;

  [Token(Token = "0x6000F4F")]
  [Address(RVA = "0x12AA010", Offset = "0x12A8E10", VA = "0x112AA010")]
  public static void ToggleWindowState(GameObject go, bool open, bool keepActive)
  {
  }

  [Token(Token = "0x6000F50")]
  [Address(RVA = "0x12A9F90", Offset = "0x12A8D90", VA = "0x112A9F90")]
  public static void ToggleWindowState(GameObject go, bool open)
  {
  }

  [Token(Token = "0x6000F51")]
  [Address(RVA = "0x12A9FB0", Offset = "0x12A8DB0", VA = "0x112A9FB0")]
  public static void ToggleWindowState(Component go, bool open)
  {
  }

  [Token(Token = "0x6000F52")]
  [Address(RVA = "0x12A9FE0", Offset = "0x12A8DE0", VA = "0x112A9FE0")]
  public static void ToggleWindowState(Component go, bool open, bool keepActive)
  {
  }

  [Token(Token = "0x6000F53")]
  [Address(RVA = "0x12A9770", Offset = "0x12A8570", VA = "0x112A9770")]
  public static void SetText(GameObject go, string text)
  {
  }

  [Token(Token = "0x6000F54")]
  [Address(RVA = "0x12A9320", Offset = "0x12A8120", VA = "0x112A9320")]
  public static void SetText(Component go, string text)
  {
  }

  [Token(Token = "0x6000F55")]
  [Address(RVA = "0x12A9320", Offset = "0x12A8120", VA = "0x112A9320")]
  public static void SetButtonText(Button go, string text)
  {
  }

  [Token(Token = "0x6000F56")]
  [Address(RVA = "0x12A9830", Offset = "0x12A8630", VA = "0x112A9830")]
  public static void SpawnParticle(
    GameObject particleObject,
    RectTransform targetRect,
    Vector2 anchor)
  {
  }

  [Token(Token = "0x6000F57")]
  [Address(RVA = "0x12A9A50", Offset = "0x12A8850", VA = "0x112A9A50")]
  public static void SpawnParticle(GameObject particleObject, Vector2 screenPosition)
  {
  }

  [Token(Token = "0x170001D1")]
  public static RectTransform Pool
  {
    [Token(Token = "0x6000F58"), Address(RVA = "0x12AA1E0", Offset = "0x12A8FE0", VA = "0x112AA1E0")] get
    {
      return (RectTransform) null;
    }
  }

  [Token(Token = "0x6000F59")]
  [Address(RVA = "0x12A7860", Offset = "0x12A6660", VA = "0x112A7860")]
  public static void AddEventListener(
    GameObject go,
    UnityEvent e,
    UIUtility.EventListener listener)
  {
  }

  [Token(Token = "0x6000F5A")]
  public static void AddEventListener<T0>(
    GameObject go,
    UnityEvent<T0> e,
    UIUtility.EventListener1Arg<T0> listener)
  {
  }

  [Token(Token = "0x6000F5B")]
  public static void AddEventListener<T0, T1>(
    GameObject go,
    UnityEvent<T0, T1> e,
    UIUtility.EventListener2Arg<T0, T1> listener)
  {
  }

  [Token(Token = "0x6000F5C")]
  public static void AddEventListener<T0, T1, T2>(
    GameObject go,
    UnityEvent<T0, T1, T2> e,
    UIUtility.EventListener3Arg<T0, T1, T2> listener)
  {
  }

  [Token(Token = "0x6000F5D")]
  public static void AddEventListener<T0, T1, T2, T3>(
    GameObject go,
    UnityEvent<T0, T1, T2, T3> e,
    UIUtility.EventListener4Arg<T0, T1, T2, T3> listener)
  {
  }

  [Token(Token = "0x6000F5E")]
  [Address(RVA = "0x12A9C20", Offset = "0x12A8A20", VA = "0x112A9C20")]
  public static IEnumerator SwitchVisibleAsync(
    List<CanvasGroup> listOn,
    List<CanvasGroup> listOff,
    float complete_time = 0.3f)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000F5F")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public UIUtility()
  {
  }

  [Token(Token = "0x20002F0")]
  public enum DialogResults
  {
    [Token(Token = "0x4000C36")] None,
    [Token(Token = "0x4000C37")] Yes,
    [Token(Token = "0x4000C38")] No,
  }

  [Token(Token = "0x20002F1")]
  public struct DialogState
  {
    [Token(Token = "0x4000C39")]
    [FieldOffset(Offset = "0x0")]
    public UIUtility.DialogResults Result;
    [Token(Token = "0x4000C3A")]
    [FieldOffset(Offset = "0x4")]
    public bool DoNotAskAgain;
  }

  [Token(Token = "0x20002F2")]
  public delegate void DialogResultEvent(GameObject dialog);

  [Token(Token = "0x20002F3")]
  public delegate void EventListener(GameObject go);

  [Token(Token = "0x20002F4")]
  public delegate void EventListener1Arg<T0>(GameObject go, T0 arg0);

  [Token(Token = "0x20002F5")]
  public delegate void EventListener2Arg<T0, T1>(GameObject go, T0 arg0, T1 arg1);

  [Token(Token = "0x20002F6")]
  public delegate void EventListener3Arg<T0, T1, T2>(GameObject go, T0 arg0, T1 arg1, T2 arg2);

  [Token(Token = "0x20002F7")]
  public delegate void EventListener4Arg<T0, T1, T2, T3>(
    GameObject go,
    T0 arg0,
    T1 arg1,
    T2 arg2,
    T3 arg3);
}
