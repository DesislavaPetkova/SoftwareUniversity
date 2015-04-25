<?php
/**
 * Created by PhpStorm.
 * User: bj
 * Date: 20/10/14
 * Time: 17:59
 */

namespace Hotel;


class Guest {

    protected $firstName;
    protected $lastName;
    protected $id;

    function __construct($firstName, $lastName, $id)
    {
        $this->lastName = $lastName;
        $this->id = $id;
        $this->firstName = $firstName;
    }

    /**
     * @param mixed $firstName
     */
    public function setFirstName($firstName)
    {
        $this->firstName = $firstName;
    }

    /**
     * @return mixed
     */
    public function getFirstName()
    {
        return $this->firstName;
    }

    /**
     * @param mixed $lastName
     */
    public function setLastName($lastName)
    {
        $this->lastName = $lastName;
    }

    /**
     * @return mixed
     */
    public function getLastName()
    {
        return $this->lastName;
    }

    /**
     * @param mixed $id
     */
    public function setId($id)
    {
        $this->id = $id;
    }

    /**
     * @return mixed
     */
    public function getId()
    {
        return $this->id;
    }

    function __toString()
    {
        return "FirstName= $this->firstName, Lastname= $this->lastName and ID: $this->id";
    }


} 