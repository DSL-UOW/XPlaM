# XPlaM 1.0

XPlaM is an eXplainable Plan Mining toolkit coded in C# using Visual Studio 2019. XPlaM aims at automating the acqusition of software agent-based models based on abductive reasoning 
and the belief–desire–intention software model. 


### Plugin Action: Convert AgentSpeak(L) Plan Library to xml,

For all of the avaliable plugin actions, it is required to serialize your AgentSpeak(L) plans and sub-plans to xml format. This plugin action leverages Jason 
implementation of the alphabet of AgentSpeak(L) language. 

#### How to use

1. Import your AgentSpeak(L) plan library in .txt format.
2. From the Action Frame, select the plugin action Convert AgentSpeak(L) Plan Library to xml.
3. Export your AgentSpeak(L) plan library in .xml format to your local disk.


### Plugin Action: Abducive design of BDI Agents

This plugin action involves some mechanism takes a set of plans and an observed action sequence, and infer a composite of plans and selection functions, such that the execution of these plans thus 
identified generates precisely the observed action sequence given the selection 
functions thus identified.

#### How to use


1. Import an AgentSpeak(L) plans (in xml format).
2. Import an action sequence (in csv fromat).
3. From the Action Frame, select the plugin action abducive design of BDI Agents.
4. Export the abducive design to your your local disk.


### Plugin Action: Context Recognition.
Context Recognition aims at explaining the behaviour of autonomous
agents by way of an explicit annotation for context conditions. This plugin action relies on accumulating the context conditions of individual actions
 specified by human experts using the history of past behaviour of the agent in an automated fashion.
 
 #### How to use


1. Import an AgentSpeak(L) plans (in xml format).
2. Import an alternative sequence of actions and object state transitions (in csv fromat).
3. Import your knowledge base (in txt fromat).
4. From the Action Frame, select the plugin action context Recognition.
