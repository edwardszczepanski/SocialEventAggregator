package com.edwardszczepanski.socialapp;

/**
 * Created by rober on 2/13/2016.
 */

/**
 * Future updates:
 *      -add event creater unique I.D. so we can ensure each user only has one event up
 * at a time.
 *      -add a real time stamp (right now just has placeholder (01012016).
 */
public class Event {
    private int eventId;
    private String eventName;
    private String eventAddress;
    private String timeStamp;


    /**
     * Event constructor.
     * @param eName
     * @param eAddress
     * @param tStamp
     */
    public Event(int id, String eName, String eAddress, String tStamp) {
        eventId = id;
        eventName = eName;
        eventAddress = eAddress;
        timeStamp = tStamp;
    }

    public int getId() {return eventId; };

    /**
     * Get function for eventName, used in addEvent function in activity_main
     * @return
     */
    public String getEventName() {
        return eventName;
    }

    /**
     * Get function for eventAddress, used in addEvent function in activity_main
     * @return
     */
    public String getEventAddress() {
        return eventAddress;
    }

    /**
     * Get function for timeStamp, used in addEvent function in activity_main
     * @return
     */
    public String getTimeStamp() {
        return timeStamp;
    }
}
