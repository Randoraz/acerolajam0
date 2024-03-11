using Godot;
using System;
using System.Collections.Generic;

[GlobalClass]
public partial class DialogScript : GodotObject
{
	public static Dictionary<string, (int, string[])> Dialog = new Dictionary<string, (int, string[])>()
	{
		{ "Init", (0, new string[]
			{
				"Start this already",
				"Then let's start. What is your name?"
			})
		},
		{ "GameOver", (0, new string[]
			{
				"YOU ALREADY KNOW WHAT I AM, DON'T YOU?"
			})
		},
		{ "Then let's start. What is your name?", (0, new string[]
			{
				"Gregor.",
				"Full name?",
				"How old are you?"
			})
		},
		{ "Full name?", (10, new string[]
			{
				"I'm sure you have it written in your papers. Don't waste my time.",
				"Fine. How old are you?",
				"Alright. Now... Do you know why are you here?"
			})
		},
		{ "Fine. How old are you?", (10, new string[]
			{
				"I'm 18.",
				"Alright. Now... Do you know why are you here?"
			})
		},
		{ "How old are you?", (10, new string[]
			{
				"I'm 18",
				"Alright. Now... Do you know why are you here?"
			})
		},
		{ "Alright. Now... Do you know why are you here?", (0, new string[]
			{
				"Yes, because I set my house on fire. That's why.",
				"And why did you do that?",
				"Do you have any family?"
			})
		},
		{ "And why did you do that?", (0, new string[]
			{
				"I was bored.",
				"You know that absolutely won't help on court, right?"
			})
		},
		{ "You know that absolutely won't help on court, right?", (0, new string[]
			{
				"Whatever. I don't really care.",
				"Do you have any family?",
				"Have any of your documents or belongings gone missing recently?"
			})
		},
		{ "Do you have any family?", (10, new string[]
			{
				"My family disappeared one year ago.",
				"I'm sorry to hear that. Do you already know what happened to them?",
				"Who disappeared, actually?",
				"Have any of your documents or belongings gone missing recently?"
			})
		},
		{ "I'm sorry to hear that. Do you already know what happened to them?", (-10, new string[]
			{
				"No. As always, the police are useless.",
				"Who disappeared, actually?",
				"Have any of your documents or belongings gone missing recently?",
				"Do you have any hobbies?"
			})
		},
		{ "Who disappeared, actually?", (0, new string[]
			{
				"My mother, my father and my older sister.",
				"I'm really sorry that happened to you. You must miss them a lot.",
				"Have any of your documents or belongings gone missing recently?",
				"Do you have any hobbies?"
			})
		},
		{ "I'm really sorry that happened to you. You must miss them a lot.", (-10, new string[]
			{
				"Yeah, I really do.",
				"Have any of your documents or belongings gone missing recently?",
				"Do you have any hobbies?"
			})
		},
		{ "Have any of your documents or belongings gone missing recently?", (10, new string[]
			{
				"My house just burnt down. What do you think?",
				"What about before that?",
				"Do you have any hobbies?"
			})
		},
		{ "What about before that?", (20, new string[]
			{
				"No. Why does it even matter?",
				"Do you have any hobbies?"
			})
		},
		{ "Do you have any hobbies?", (10, new string[]
			{
				"I'm a swimmer. I already won many competitions.",
				"Oh, sounds impressive! What was the last competition you won?",
				"Anything else you like to do?"
			})
		},
		{ "Oh, sounds impressive! What was the last competition you won?", (-10, new string[]
			{
				"The city's championship between schools. I even make cookies for the whole team to celebrate.",
				"Congratulations! Do you plan to keep training after you are done with school?",
				"Oh? So you also like baking?"
			})
		},
		{ "Congratulations! Do you plan to keep training after you are done with school?", (-10, new string[]
			{
				"Yes. I plan on applying for a scholarship in the university close by.",
				"If you already had this plan, why did you burn your house?",
				"Anything else you like to do?"
			})
		},
		{ "If you already had this plan, why did you burn your house?", (30, new string[]
			{
				"Like I told you, I was bored. I wanted to feel something, do something.",
				"And why is that?"
			})
		},
		{ "Oh? So you also like baking?", (10, new string[]
			{
				"Not really. But I did it to celebrate at the time.",
				"Do you prefer cooking?"
			})
		},
		{ "Do you prefer cooking?", (20, new string[]
			{
				"I guess cooking can be fun, sometimes.",
				"Why just sometimes?"
			})
		},
		{ "Anything else you like to do?", (10, new string[]
			{
				"I guess cooking can be fun, sometimes.",
				"Why just sometimes?"
			})
		},
		{ "Why just sometimes?", (20, new string[]
			{
				"I'm afraid of fire. I'm always afraid to get burnt when cooking.",
				"Why did you set your house on fire then?"
			})
		},
		{ "Why did you set your house on fire then?", (30, new string[]
			{
				"Like I told you, I was bored. I wanted to feel something, do something.",
				"And why is that?"
			})
		},
		{ "And why is that?", (10, new string[]
			{
				"I'm still recovering from a leg injury. So I can't swim anymore.",
				"Oh my, that's a pity. How did you get hurt?"
			})
		},
		{ "Oh my, that's a pity. How did you get hurt?", (-10, new string[]
			{
				"I pushed my limits too hard on the last competition I was in, two months ago. I won though. You should've seen my mother's face. She was so proud.",
				"I thought she disappeared one year ago.",
				"I bet she was indeed. Were you close to her?"
			})
		},
		{ "I thought she disappeared one year ago.", (20, new string[]
			{
				"Come on, you should've known that was a lie. You're not so smart.",
				"Listen, I won't be able to help you if you keep lying.",
				"Listen, I know you are going through a tough time, but I'm just trying to help you.",
				"Listen, your behaviour has been weird since the beginning. Are you hiding something?"
			})
		},
		{ "Listen, I won't be able to help you if you keep lying.", (0, new string[]
			{
				"Fine. Whatever.",
				"Let me try asking again: What's your full name?",
				"Where is your family now?",
				"Are you a doppelganger?"
			})
		},
		{ "Listen, I know you are going through a tough time, but I'm just trying to help you.", (-20, new string[]
			{
				"Alright... I'm sorry. I'll be honest now.",
				"Thank you. Now, what's your full name?",
				"Where is your family now?",
				"Are you a doppelganger?"
			})
		},
		{ "Listen, your behaviour has been weird since the beginning. Are you hiding something?", (-1, new string[]
			{
				"YOU KNOW YOU SHOULDN'T EXPOSE ME!"
			})
		},
		{ "Let me try asking again: What's your full name?", (0, new string[]
			{
				"Gregor Hatespolicius",
				"Alright, we are done here.",
				"Are you a doppelganger?"
			})
		},
		{ "Thank you. Now, what's your full name?", (0, new string[]
			{
				"Gregor Octavius",
				"Where is your family now?",
				"Are you a doppelganger?"
			})
		},
		{ "Where is your family now?", (10, new string[]
			{
				"They went travelling abroad last week. I couldn't join because my leg hurts. I guess that's why I did what I did.",
				"Thank you. That's all I needed to know. Your collaboration is appreciated.",
				"Are you a doppelganger?"
			})
		},
		{ "Are you a doppelganger?", (-1, new string[]
			{
				"WHAT DO YOU THINK, INSPECTOR?"
			})
		},
		{ "Thank you. That's all I needed to know. Your collaboration is appreciated.", (0, new string[]
			{
				"No. Thank YOU, inspector. Glad to know we are indeed everywhere now."
			})
		},
		{ "I bet she was indeed. Were you close to her?", (-10, new string[]
			{
				"Yeah, she was always really sweet. I hope she is fine, wherever she is.",
				"Did you notice anything suspicious before she disappeared?"
			})
		},
		{ "Did you notice anything suspicious before she disappeared?", (10, new string[]
			{
				"Like what?",
				"Memory loss, unusual behaviour...",
				"Anything you think could help us to find her."
			})
		},
		{ "Memory loss, unusual behaviour...", (20, new string[]
			{
				"I guess one day she seemed to have forgotten my name. That was weird.",
				"Let's go back to you. When was the last time you went swimming?",
			})
		},
		{ "Let's go back to you. When was the last time you went swimming?", (10, new string[]
			{
				"Didn't I already tell you? It was last week, in the ocean.",
				"Sorry, I just forgot to write that down.",
				"I thought you said last month, in the competition where you got hurt?"
			})
		},
		{ "Sorry, I just forgot to write that down.", (-10, new string[]
			{
				"It's fine, I guess.",
				"If you could just tell me your full name, then we'd be done here."
			})
		},
		{ "If you could just tell me your full name, then we'd be done here.", (10, new string[]
			{
				"Fine. It's Gregor Octavius.",
				"Thank you for the cooperation. You may go now.",
			})
		},
		{ "Thank you for the cooperation. You may go now.", (0, new string[]
			{
				"Be careful with my information. That's all I'm going to say."
			})
		},
		{ "Anything you think could help us to find her.", (-10, new string[]
			{
				"Not really. She just went to work as always, but never came home. Same goes for the others.",
				"Let's go back to you. When was the last time you went swimming?",
			})
		},
		{ "I thought you said last month, in the competition where you got hurt?", (20, new string[]
			{
				"If you already knew that, why did you ask? What are you trying to prove here?",
				"That you are a doppelganger.",
				"Just confirming information, nothing else."
			})
		},
		{ "That you are a doppelganger.", (-1, new string[]
			{
				"HOW DARE YOU EXPOSE ME?"
			})
		},
		{ "Just confirming information, nothing else.", (-10, new string[]
			{
				"Fine.",
				"If you could just tell me your full name, then we'd be done here."
			})
		}
	};
}
